// TTDS.CustomMathProject.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "TTDS.CustomMathProject.h"


// This is an example of an exported variable
TTDSCUSTOMMATHPROJECT_API int nTTDSCustomMathProject=0;

// This is an example of an exported function.
TTDSCUSTOMMATHPROJECT_API int fnTTDSCustomMathProject(void)
{
    return 0;
}

// This is the constructor of a class that has been exported.
CTTDSCustomMathProject::CTTDSCustomMathProject()
{
    return;
}

double CTTDSCustomMathProject::Sum(double a, double b)
{
    return a+b;
}
double CTTDSCustomMathProject::Difference(double a, double b)
{
    return a - b;
}