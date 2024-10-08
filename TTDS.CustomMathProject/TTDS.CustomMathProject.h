// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the TTDSCUSTOMMATHPROJECT_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// TTDSCUSTOMMATHPROJECT_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef TTDSCUSTOMMATHPROJECT_EXPORTS
#define TTDSCUSTOMMATHPROJECT_API __declspec(dllexport)
#else
#define TTDSCUSTOMMATHPROJECT_API __declspec(dllimport)
#endif

// This class is exported from the dll
class TTDSCUSTOMMATHPROJECT_API CTTDSCustomMathProject {
public:
	CTTDSCustomMathProject(void);
	// TODO: add your methods here.
public:
	double Sum(double a, double b);
	double Difference(double a, double b);
};

extern TTDSCUSTOMMATHPROJECT_API int nTTDSCustomMathProject;

TTDSCUSTOMMATHPROJECT_API int fnTTDSCustomMathProject(void);
