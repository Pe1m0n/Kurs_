#pragma once
#include "Studio.h"
class Working_Studio
{
private:
	int totalHorror = 0;
	int totalFPS = 0;
	double money = 0;
	Studio* stud;

	Horror_Game** Horrors;
	FPS_Game** FPSs;

public:
	Working_Studio(Studio* s, int horror_count, int fps_count, double money_count);
	Working_Studio();
	~Working_Studio();

	void sell();
	void info();

	int getTotalHorror();
	int getTotalFPS();
	double getTotalMoney();

	void Add_FPS();
	void TAdd(int horror_count, int fps_count);
	void Add_Horror();

};

