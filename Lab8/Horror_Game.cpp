#include <iostream>
#include "Horror_Game.h"
using namespace std;

Horror_Game::Horror_Game()
{
	
	
		cout << "\n������� ���� ������������ �������\n";
		cin >> this->makeprice;
		if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������,
		{
			cout << "\n�� �������� ����� ������������ �������� ������������ ���������";
			cout << "\n���� ������������ ����� �������� ��� 0";
			this->makeprice = 0;


		}
		else
			if (this->makeprice < 0) {
			cout << "\n���� ������������ ���� ���� �������� ������������ ���������";
			cout << "\n���� ������������ ����� �������� ��� 0";
			this->makeprice = 0;
			}


		

		std::cin.clear(); // �� ���������� cin � '�������' ����� ������
		std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������

	
	
		cout << "\n������� ����������� ������� � ���������\n";
		cin >> this->sellpercent;
		if (std::cin.fail()) // ���� ���������� ���������� ��������� ���������
		{
			cout << "\n�� �������� ����������� �������� ������������ ���������";
			cout << "\n����������� ���� ����� �������� ��� 100%";
			this->sellpercent = 100;

		}
		else
			if (this->sellpercent < 0) {
			cout << "\n����������� ���� ���� �������� ������������ ���������";
			cout << "\n����������� ���� ����� �������� ��� 100%";
			this->sellpercent = 100;
			}
		

		std::cin.clear(); // �� ���������� cin � '�������' ����� ������
		std::cin.ignore(numeric_limits<streamsize>::max(), '\n'); // � ������� �������� ����������� ����� �� �������� ������


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