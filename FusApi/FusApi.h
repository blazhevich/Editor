// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the {0}_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// {0}_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef FUSAPI_EXPORTS
#define FUSAPI_API __declspec(dllexport)
#else
#define FUSAPI_API __declspec(dllimport)
#endif

// This class is exported from the dll
class FUSAPI_API CFusApi {
public:
	CFusApi(void);
	// TODO: add your methods here.
};

extern FUSAPI_API int nFusApi;

FUSAPI_API int fnFusApi(void);
