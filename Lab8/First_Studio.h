#pragma once


#include "Studio.h"


class First_Studio :
    public Studio
{

    public:

        Horror_Game* createHorror();
        FPS_Game* createFPS();
};

