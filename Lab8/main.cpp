#include <iostream>
#include <conio.h>
#include "First_Studio.h"
#include "Second_Studio.h"
#include "Working_Studio.h"

using namespace std;

void menu(int i);

int main() {

	setlocale(0, "RUS");

	char key1;
	char key2;
	char key3;

	int cohg;
	int cofg;
	double money;


	First_Studio* F = new First_Studio();

	Second_Studio* S = new Second_Studio();

	Working_Studio* W1 = new Working_Studio();
	Working_Studio* W2 = new Working_Studio();


	do
	{
		menu(0);

		key1 = _getch();
		switch (key1)
		{
		case '1':
			do
			{
				menu(1);
				key2 = _getch();
				switch (key2)
				{
				case '1':
					cout << endl << "Введите количество Хорроров производящихся сейчас" << endl;
					cin >> cohg;

					if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
					{
						cout << endl << "Вы вели не число";
						cout << endl << "Количество Хорроров будет 0";
						cohg = 0;


					}


					std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
					std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера

					cout << endl << "Введите количество Шутеров производящихся сейчас" << endl;
					cin >> cofg;

					if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
					{
						cout << endl << "Вы вели не число";
						cout << endl << "Количество Шутеров будет 0";
						cohg = 0;


						
					}

					std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
					std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера

					cout << endl << "Введите количество Денег у компании" << endl;
					cin >> money;

					if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
					{
						cout << endl << "Вы вели не число";
						cout << endl << "Количество денег будет 2000";
						money = 2000;

					}

					std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
					std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера


					W1 = new Working_Studio(F, cohg, cofg, money);

					break;

				case '2':
					cout << endl << "1:Создать Хоррор";
					cout << endl << "2:Создать Шутер";
					key3 = _getch();
					switch (key3)
					{
					case'1':
						W1->Add_Horror();
						break;
					case'2':
						W1->Add_FPS();
						break;
					default:
						break;
					}
					break;

				case '3':
					cout << endl << "В данный момент первая компания разрабатывает " << W1->getTotalHorror() << " Хорроров";
					break;

				case '4':
					cout << endl << "В данный момент первая компания разрабатывает " << W1->getTotalFPS() << " Шутеров";
					break;

				case '5':
					cout << endl << "В данный момент первая компания имеет " << W1->getTotalMoney() << " Валюты";
					break;

				case '6':
					W1->sell();
					break;

				default:
					break;
				}
			}
			while (key2!=27);
		break;

		case '2':
			do
			{
				menu(2);
				key2 = _getch();
				switch (key2)
			{
			case '1':
				cout << endl << "Введите количество Хорроров производящихся сейчас" << endl;
				cin >> cohg;

				if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
				{
					cout << endl << "Вы вели не число";
					cout << endl << "Количество Хорроров будет 0";
					cohg = 0;
					
				}

				std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
				std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера


				cout << endl << "Введите количество Шутеров производящихся сейчас" << endl;
				cin >> cofg;

				if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
				{
					cout << endl << "Вы вели не число";
					cout << endl << "Количество Шутеров будет 0";
					cohg = 0;

				}


				std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
				std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера


				cout << endl << "Введите количество Денег у компании" << endl;
				cin >> money;

				if (std::cin.fail()) // если предыдущее извлечение оказалось неудачным,
				{
					cout << endl << "Вы вели не число";
					cout << endl << "Количество денег будет 2000";
					money = 2000;

				}


				std::cin.clear(); // то возвращаем cin в 'обычный' режим работы
				std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // и удаляем значения предыдущего ввода из входного буфера

				cout << endl;

				W2 = new Working_Studio(S, cohg, cofg, money);

				break;

			case '2':
				cout << endl << "1:Создать Хоррор";
				cout << endl << "2:Создать Шутер";
				key3 = _getch();
				switch (key3)
				{
				case'1':
					W2->Add_Horror();
					break;
				case'2':
					W2->Add_FPS();
					break;
				default:
					break;
				}
				break;

			case '3':
				cout << endl << "В данный момент вторая компания разрабатывает " << W2->getTotalHorror() << " Хорроров";
				break;

			case '4':
				cout << endl << "В данный момент вторая компания разрабатывает " << W2->getTotalFPS() << " Шутеров";
				break;

			case '5':
				cout << endl << "В данный момент вторая компания имеет " << W2->getTotalMoney() << " Валюты";
				break;

			case '6':
				W2->sell();
				break;

			default:
				break;
			}
			}
			while (key2 != 27);

		break;

		default:
			break;
		}
		


		
	}


	while (key1 != 27);
}

void menu(int i) {
	if (i == 0)
	{
		cout << endl << "1:Управление первой компанией";
		cout << endl << "2:Управление второй компанией";
		cout << endl << "Esc:Завершение работы" << endl;
	}
	else
		if (i == 1 || i == 2)
		{
			cout << endl << "1:Создать компанию со стартовыми заказами";
			cout << endl << "2:Добавить закзов";
			cout << endl << "3:Вывести количество разрабатываемых Хорроров компании";
			cout << endl << "4:Вывести количество разрабатываемых Шутеров компании";
			cout << endl << "5:Вывести количество денег компании";
			cout << endl << "6:Выпусть все игры на продажу";
			cout << endl << "Esc:Вернуться назад" << endl;
		}

}