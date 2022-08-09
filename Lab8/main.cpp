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
					cout << endl << "������� ���������� �������� �������������� ������" << endl;
					cin >> cohg;

					if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
					{
						cout << endl << "�� ���� �� �����";
						cout << endl << "���������� �������� ����� 0";
						cohg = 0;


					}


					std::cin.clear(); // �� ���������� cin � '�������' ����� ������
					std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������

					cout << endl << "������� ���������� ������� �������������� ������" << endl;
					cin >> cofg;

					if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
					{
						cout << endl << "�� ���� �� �����";
						cout << endl << "���������� ������� ����� 0";
						cohg = 0;


						
					}

					std::cin.clear(); // �� ���������� cin � '�������' ����� ������
					std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������

					cout << endl << "������� ���������� ����� � ��������" << endl;
					cin >> money;

					if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
					{
						cout << endl << "�� ���� �� �����";
						cout << endl << "���������� ����� ����� 2000";
						money = 2000;

					}

					std::cin.clear(); // �� ���������� cin � '�������' ����� ������
					std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������


					W1 = new Working_Studio(F, cohg, cofg, money);

					break;

				case '2':
					cout << endl << "1:������� ������";
					cout << endl << "2:������� �����";
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
					cout << endl << "� ������ ������ ������ �������� ������������� " << W1->getTotalHorror() << " ��������";
					break;

				case '4':
					cout << endl << "� ������ ������ ������ �������� ������������� " << W1->getTotalFPS() << " �������";
					break;

				case '5':
					cout << endl << "� ������ ������ ������ �������� ����� " << W1->getTotalMoney() << " ������";
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
				cout << endl << "������� ���������� �������� �������������� ������" << endl;
				cin >> cohg;

				if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
				{
					cout << endl << "�� ���� �� �����";
					cout << endl << "���������� �������� ����� 0";
					cohg = 0;
					
				}

				std::cin.clear(); // �� ���������� cin � '�������' ����� ������
				std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������


				cout << endl << "������� ���������� ������� �������������� ������" << endl;
				cin >> cofg;

				if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
				{
					cout << endl << "�� ���� �� �����";
					cout << endl << "���������� ������� ����� 0";
					cohg = 0;

				}


				std::cin.clear(); // �� ���������� cin � '�������' ����� ������
				std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������


				cout << endl << "������� ���������� ����� � ��������" << endl;
				cin >> money;

				if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
				{
					cout << endl << "�� ���� �� �����";
					cout << endl << "���������� ����� ����� 2000";
					money = 2000;

				}


				std::cin.clear(); // �� ���������� cin � '�������' ����� ������
				std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������

				cout << endl;

				W2 = new Working_Studio(S, cohg, cofg, money);

				break;

			case '2':
				cout << endl << "1:������� ������";
				cout << endl << "2:������� �����";
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
				cout << endl << "� ������ ������ ������ �������� ������������� " << W2->getTotalHorror() << " ��������";
				break;

			case '4':
				cout << endl << "� ������ ������ ������ �������� ������������� " << W2->getTotalFPS() << " �������";
				break;

			case '5':
				cout << endl << "� ������ ������ ������ �������� ����� " << W2->getTotalMoney() << " ������";
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
		cout << endl << "1:���������� ������ ���������";
		cout << endl << "2:���������� ������ ���������";
		cout << endl << "Esc:���������� ������" << endl;
	}
	else
		if (i == 1 || i == 2)
		{
			cout << endl << "1:������� �������� �� ���������� ��������";
			cout << endl << "2:�������� ������";
			cout << endl << "3:������� ���������� ��������������� �������� ��������";
			cout << endl << "4:������� ���������� ��������������� ������� ��������";
			cout << endl << "5:������� ���������� ����� ��������";
			cout << endl << "6:������� ��� ���� �� �������";
			cout << endl << "Esc:��������� �����" << endl;
		}

}