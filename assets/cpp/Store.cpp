//Name: Matt Maxwell
//Date: 6/7/2017
//Description: This cpp file stores information for the Store.hpp file. Which is used to
// simulate a shopping cart and process the shopping cart.

#include "stdafx.h"
#include "Store.hpp"
#include "Product.hpp"
#include "Customer.hpp"
#include <string>
#include <vector>
#include <iostream>
using namespace std;

//Add product to inventory vector
void Store::addProduct(Product * p)
{
	inventory.push_back(p);
}
//Add customer to members vector
void Store::addMember(Customer * c)
{
	members.push_back(c);
}
//Points to product to find out if it is a real product ID
Product * Store::getProductFromID(std::string ID)
{
	for (int i = 0; i < inventory.size(); i++)
	{
		if (ID.compare(inventory[i]->getIdCode()) == 0) //if true return the address of [i]
			return inventory[i];
	}
	return NULL;//if false return 0
}
//Points to customer to find out the member ID
Customer * Store::getMemberFromID(std::string ID)
{
	for (int i = 0; i < members.size(); i++)
	{
		if (ID.compare(members.at(i)->getAccountID()) == 0) //if true it returns the address of [i]
			return members[i];
	}
	return NULL;//if false returns 0
}
//Search the store for the string
void Store::productSearch(std::string str)
{		//loop through inventory
	for (int i = 0; i < inventory.size(); i++)
	{
		if ((inventory[i]->getTitle().find(str) != string::npos) || (inventory[i]->getDescription().find(str) != string::npos))//compares str to name or description
		{
			cout << inventory[i]->getTitle() << endl;//when it gets a match print out the title, id code, price, and description of inventory[i]
			cout << "ID code: " << inventory[i]->getIdCode() << endl;
			cout << "Price $" << inventory[i]->getPrice() << endl;
			cout << inventory[i]->getDescription() << endl << endl;
		}
	}
}
//Add product to member's cart
void Store::addProductToMemberCart(std::string pID, std::string mID)
{
	int flag = 0; //flag to determine what to do
	int quantity; //holder value
	int member; //holder value
	//loop through inventory and see if it is a real ID code
	for (int i = 0; i < inventory.size(); i++)
	{
		if (pID.compare(inventory[i]->getIdCode()) == 0)
		{
			flag = 1;//if matches set flag to 1
			quantity = inventory[i]->getQuantityAvailable();//set quantity to available quantity
		}
	}
	
	if (flag == 1) //proceed forward
	{
		for (int m = 0; m < members.size(); m++)//loop members to find account ID
		{
			if (mID.compare(members.at(m)->getAccountID()) == 0)
			{
				flag = 2;//set flag to 2
				member = m; //hold info of m in member
			}
		}

		if (flag == 2)//proceed forward
		{
			if (quantity > 0) //if able to buy test
			{
				members.at(member)->addProductToCart(pID);//add to the cart
			}
			else
				cout << "Sorry, product #" << pID << " is currently out of stock." << endl; //if quantity is 0
		}
		else
			cout << "Sorry, member #" << mID << " not found." << endl;//cannot find member ID
	}
	else
		cout << "Product #" << pID << " not found." << endl;//cannot find product ID
}
//ring up the member
void Store::checkOutMember(std::string mID)
{
	int flag = 0;//flag
	vector<string> custCat; //copy the cart into here
	double shipping;//holds which shipping price to use
	int quantity;//holds quantity
	double total;//total of the order
	double subtotal = 0;//total of the order minus shipping.

	for (int m = 0; m < members.size(); m++)//loop members
	{
		if (mID.compare(members.at(m)->getAccountID()) == 0)//find a match of member ID
		{
			flag = 1;//match found
			custCat = members.at(m)->getCart();//get the member's cart

			if (members[m]->isPremiumMember())//find out if premium member
			{
				shipping = 0;//if yes set shipping cost to 0
			}
			else //otherwise set it to /07
			{
				shipping = .07;
			}
		}
	}

	if (flag == 1)//proceed forward
	{
		if (custCat.size() != 0)//if vector is not empty
		{
			for (int c = 0; c < custCat.size(); c++)//loop customers
			{
				for (int i = 0; i < inventory.size(); i++)//loop inventory
				{
					if (inventory[i]->getIdCode() == (custCat[c]))//if there is a match
					{
						quantity = inventory[i]->getQuantityAvailable();//get the quantity

						if (quantity >= 1)//if there is enough quantity
						{
							subtotal += inventory[i]->getPrice();//set subtotal
							inventory[i]->decreaseQuantity();//decrease quantity
							cout << inventory[i]->getTitle() << " - $" << inventory[i]->getPrice() << endl;//print out the item name and price
						}
						else//if no valid product ID print out no longer available.
						{
							cout << "Sorry product #" << inventory[i]->getIdCode() << ", " << inventory[i]->getTitle() <<
								", is no longer available." << endl;
						}
					}
				}
			}
			total = subtotal + (subtotal * shipping);//get total cost
			cout << "Subtotal: $" << subtotal << endl;//total cost minus shipping
			cout << "Shipping cost: $" << (subtotal * shipping) << endl;//shipping cost
			cout << "Total: $" << total << endl;//entire total of the order
		}
		else//there is nothing in the cart
		{
			cout << "The cart is empty.\n";
		}
	}
	else//not a member
	{
		cout << "Member ID #" << mID << " not found.\n\n";
	}


custCat.empty();//empty the cart out
}
