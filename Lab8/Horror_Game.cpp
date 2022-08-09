#include <iostream>
#include "Horror_Game.h"
using namespace std;

Horror_Game::Horror_Game()
{
	
	
		cout << "\nВведите цену производства Хоррора\n";
		cin >> this->makeprice;
		if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
		{
			cout << "\nНе числовая ценая производства является недопустимым значением";
			cout << "\nЦена производства будет указанна как 0";
			this->makeprice = 0;


		}
		else
			if (this->makeprice < 0) {
			cout << "\nЦена производства ниже нуля является недопустимым значением";
			cout << "\nЦена производства будет указанна как 0";
			this->makeprice = 0;
			}


		

		std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
		std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера

	
	
		cout << "\nВведите окупаемость Хоррора в процентах\n";
		cin >> this->sellpercent;
		if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным
		{
			cout << "\nНе числовая окупаемость является недопустимым значением";
			cout << "\nОкупаемость игры будет указанна как 100%";
			this->sellpercent = 100;

		}
		else
			if (this->sellpercent < 0) {
			cout << "\nОкупаемость ниже нуля является недопустимым значением";
			cout << "\nОкупаемость игры будет указанна как 100%";
			this->sellpercent = 100;
			}
		

		std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
		std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера


}
Horror_Game::~Horror_Game() {

}

double Horror_Game::getpercent()
{
	return this->sellpercent;
}

double Horror_Game::getprice()
{
	return this->makeprice;
}