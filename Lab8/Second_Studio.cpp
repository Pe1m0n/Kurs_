#include "Horror_Game.h"
#include "FPS_Game.h"
#include "Second_Studio.h"

FPS_Game* Second_Studio::createFPS()
{
	return new FPS_Game();
}

Horror_Game* Second_Studio::createHorror()
{
	return new Horror_Game();
}
