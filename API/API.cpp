// API.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <vector>
#include <algorithm>

typedef void(__stdcall *IntCallback)(long result);
typedef void(__stdcall *FloatCallback)(float result);
typedef void(__stdcall *DoubleCallback)(double result);

#define RET_ELEMENTS_NUM 30

extern "C"
{
	void __declspec(dllexport) __stdcall GetInt64Values(IntCallback cb)
	{
		try
		{
			std::vector<long> v(RET_ELEMENTS_NUM);
			std::generate(v.begin(), v.end(), std::rand);
			for (int i = 0; i < v.size(); i++)
			{
				cb(v[i]);
			}
		}
		catch (...)
		{
			MessageBox(0, L"Error in GetInt64Values!", L"Xu ^_^", 0);
		}
	}

	void __declspec(dllexport) __stdcall GetFloatValues(FloatCallback cb)
	{
		try
		{
			std::vector<float> v(RET_ELEMENTS_NUM);
			std::generate(v.begin(), v.end(), std::rand);
			for (int i = 0; i < v.size(); i++)
			{
				cb(v[i]);
			}
		}
		catch (...)
		{
			MessageBox(0, L"Error in GetFloatValues!", L"Xu ^_^", 0);
		}
	}

	void __declspec(dllexport) __stdcall GetDoubleValues(DoubleCallback cb)
	{
		try
		{
			std::vector<double> v(RET_ELEMENTS_NUM);
			std::generate(v.begin(), v.end(), std::rand);
			for (int i = 0; i < v.size(); i++)
			{
				cb(v[i]);
			}
		}
		catch (...)
		{
			MessageBox(0, L"Error in GetDoubleValues!", L"Xu ^_^", 0);
		}
	}
}