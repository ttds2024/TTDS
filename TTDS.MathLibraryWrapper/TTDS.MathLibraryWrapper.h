#pragma once
#include "../TTDS.CustomMathProject/TTDS.CustomMathProject.h"
#include <vcclr.h>
#pragma comment (lib, "TTDSCustomMathProject.lib")
using namespace System;
using namespace System::Runtime::InteropServices;

namespace TTDSMathLibraryWrapper {
	public ref class MathLibraryWrapper
	{
		// TODO: Add your methods for this class here.

		public:
			double Sum(double a, double b)
			{
				CTTDSCustomMathProject instance;

				return instance.Sum(a, b);
			}

			double Difference(double a, double b)
			{
				CTTDSCustomMathProject instance;

				return instance.Difference(a, b);
			}
	};
}
