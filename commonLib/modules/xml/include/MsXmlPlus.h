//
//		MsmlPlus.h
//
//		MSXML関連関数
//
//		'09/09/14	Ver 1.00	初版                 by iwakura
//		'10/01/05	Ver 1.01	NodeTextToBOOL 追加  by iwakura
//
//

#pragma once

#include <vector>
#include <boost/lexical_cast.hpp>

//#import "msxml3.dll" named_guids
#import "msxml6.dll" named_guids

BOOL NodeTextToInt(MSXML2::IXMLDOMNodePtr& pNode, int* pIntReturn);
BOOL NodeTextToInt64(MSXML2::IXMLDOMNodePtr& pNode, long long* pIntReturn);
BOOL NodeTextToBOOL(MSXML2::IXMLDOMNodePtr& pNode, BOOL* pBoolReturn);
BOOL NodeTextToDouble(MSXML2::IXMLDOMNodePtr& pNode, double* pDoubleReturn);
BOOL NodeListTextToStringVector(MSXML2::IXMLDOMNodeListPtr& pNodeList, std::vector<bstr_t>* pStrVecReturn);

template<typename T> BOOL NodeTextToNum(MSXML2::IXMLDOMNodePtr& pNode, T* pIntReturn)
{
	if( pIntReturn == NULL ) return FALSE;

	try
	{
		*pIntReturn = boost::lexical_cast<T>(pNode->text);

	} catch( ... /*const boost::bad_lexical_cast& e*/ ) {
		// 文字列を数値に変換できなかった

		return FALSE;
	}

	return TRUE;
}