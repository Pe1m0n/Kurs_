#include "Horror_Game.h"
#include "FPS_Game.h"
#include "First_Studio.h"

FPS_Game* First_Studio::createFPS()
{
	return new FPS_Game();
}

Horror_Game* First_Studio::createHorror()
{
	return new Horror_Game();
}