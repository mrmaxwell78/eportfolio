//Name: Matt Maxwell
//Date: 6/7/2017
//Description: Stores functions for customer.hpp and accesses private member functions

#include "stdafx.h"
#include "Customer.hpp"
#include <iostream>
using namespace std;


Customer::Customer(string n, string a, bool pm)//default constructor
{
	name = n;//customer name
	accountID = a;//customer account id
	premiumMember = pm;//premium member or not
}

string Customer::getAccountID()//access account id
{
	return accountID;
}

vector<string> Customer::getCart()//access customer's cart
{
	return cart;
}

void Customer::addProductToCart(string sid)//add to the customer's cart
{
	cart.push_back(sid);
}

bool Customer::isPremiumMember()//find out if premium member
{
	if(premiumMember == true)//yes premium
	{
		return true;
	}
	return false;//not premium
}

void Customer::emptyCart()//empty out the cart vector
{
	cart.empty();
}
