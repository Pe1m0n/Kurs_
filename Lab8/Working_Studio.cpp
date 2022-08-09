#include <iostream>
#include "Working_Studio.h"

using namespace std;

Working_Studio::Working_Studio(Studio* s, int horror_count, int fps_count, double money_count)
{

	this->totalFPS = 0;
	this->totalHorror = 0;
	this->money = money_count;
	this->FPSs = new FPS_Game * [horror_count];
	this->Horrors = new Horror_Game * [fps_count];
	this->stud = s;

	for (int i = 0; i < horror_count; i++)
	{
		Horror_Game* h = s->createHorror();

		if (h->getprice() <= this->money)
		{
			this->Horrors[this->totalHorror] = h;
			this->totalHorror++;
			this->money -= h->getprice();
		}
		else
			break;
	}

	for (int i = 0; i < fps_count; i++)
	{
		FPS_Game* f = s->createFPS();

		if (f->getprice() <= this->money)
		{
			this->FPSs[this->totalFPS] = f;
			this->totalFPS++;
			this->money -= f->getprice();
		}
		else
			break;
	}
}


int Working_Studio::getTotalFPS()
{
	return this->totalFPS;
}

int Working_Studio::getTotalHorror()
{
	return this->totalHorror;
}

void Working_Studio::Add_FPS()
{
	this->totalFPS ++;

	FPS_Game* f = this->stud->createFPS();

	if (f->getprice() <= this->money)
	{
		this->FPSs[this->totalFPS] = f;
		this->totalFPS++;
		this->money -= f->getprice();
	}

}

void Working_Studio::Add_Horror()
{

	this->totalHorror++;

	Horror_Game* h = this->stud->createHorror();

	if (h->getprice() <= this->money)
	{
		this->Horrors[this->totalHorror] = h;
		this->totalHorror++;
		this->money -= h->getprice();
	}

}

double Working_Studio::getTotalMoney()
{
	
	return this->money;
}

void Working_Studio::info()
{
	printf("Хорроры: %d", this->totalFPS);
	printf("Шутеры: %d", this->totalHorror);
	printf("Осталось деняк у студии: %lf", this->money);
}

void Working_Studio::sell()
{
	int n = this->getTotalFPS();

	while (n-- || n >= 0)
		this->money += ((this->FPSs[n]->getpercent())/100) * (this->FPSs[n]->getprice());

	this->totalFPS = 0;

	n = this->getTotalHorror();

	while (n-- || n >= 0)
		this->money += ((this->Horrors[n]->getpercent()) / 100) * (this->Horrors[n]->getprice());

	this->totalHorror = 0;

}

void Working_Studio::TAdd(int horror_count, int fps_count) {


	for (int i = 0; i < horror_count; i++)
	{
		Horror_Game* h = this->stud->createHorror();

		if (h->getprice() <= this->money)
		{
			this->Horrors[this->totalHorror] = h;
			this->totalHorror++;
			this->money -= h->getprice();
		}
		else
			break;
	}

	for (int i = 0; i < fps_count; i++)
	{
		FPS_Game* f = this->stud->createFPS();

		if (f->getprice() <= this->money)
		{
			this->FPSs[this->totalFPS] = f;
			this->totalFPS++;
			this->money -= f->getprice();
		}
		else
			break;
	}



}

Working_Studio::Working_Studio() {
}

Working_Studio::~Working_Studio() {

}