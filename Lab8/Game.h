#pragma once

class Game
{
protected:
	double makeprice;
	double sellpercent;
public:
	virtual double getprice() = 0;
	virtual double getpercent() = 0;
};
