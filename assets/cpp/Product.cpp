//Name: Matt Maxwell
//Date: 6/7/2017
//Description: This cpp file holds info of the product.hpp and has the functions defined of product information

#include "stdafx.h"
#include "Product.hpp"
#include <string>
#include <vector>
#include <iostream>
using namespace std;

//default constructor
Product::Product(string id, string t, string d, double p, int qa)
{
	idCode = id;//idcode of item
	title = t;//title of item
	description = d;//description of item
	price = p;//price of item
	quantityAvailable = qa;//how much of it there is
}

string Product::getIdCode()//access the id code
{
	return idCode;
}

string Product::getTitle()//access the title
{
	return title;
}

string Product::getDescription()//access the description
{
	return description;
}

double Product::getPrice()//access the price
{
	return price;
}

int Product::getQuantityAvailable()//access how much there is
{
	return quantityAvailable;
}

void Product::decreaseQuantity()//SOMEONE BOUGHT SOMETHING YAY oh and decrease the quantity
{
	quantityAvailable -= 1;
}
