#pragma once

#include "FPS_Game.h"
#include "Horror_Game.h"

class Studio
{
public:
	virtual FPS_Game* createFPS() = 0;
	virtual Horror_Game* createHorror() = 0;
};

