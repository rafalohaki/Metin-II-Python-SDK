﻿using System;
using System.Diagnostics;

//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_WINTRUST (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_WEBSERVICES (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_EVENTLOGSERVICE (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_VHD (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_PERFCOUNTER (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_SECURESTARTUP (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_REMOTEFS (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_BOOTABLESKU (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_CMD (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_CMDTOOLS (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_DISM (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_CORESETUP (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_APPRUNTIME (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_ESENT (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PKG_WINMGMT (WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_FAMILY_APP WINAPI_FAMILY_PC_APP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_FAMILY WINAPI_FAMILY_DESKTOP_APP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_DESKTOP (WINAPI_FAMILY == WINAPI_FAMILY_DESKTOP_APP)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_APP (WINAPI_FAMILY == WINAPI_FAMILY_DESKTOP_APP || WINAPI_FAMILY == WINAPI_FAMILY_PC_APP || WINAPI_FAMILY == WINAPI_FAMILY_PHONE_APP)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PC_APP (WINAPI_FAMILY == WINAPI_FAMILY_DESKTOP_APP || WINAPI_FAMILY == WINAPI_FAMILY_PC_APP)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PHONE_APP (WINAPI_FAMILY == WINAPI_FAMILY_PHONE_APP)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_SYSTEM (WINAPI_FAMILY == WINAPI_FAMILY_SYSTEM || WINAPI_FAMILY == WINAPI_FAMILY_SERVER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_PARTITION_PHONE WINAPI_PARTITION_PHONE_APP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINAPI_FAMILY_PARTITION(Partitions) (Partitions)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _WINAPI_DEPRECATED_DECLARATION __declspec(deprecated("This API cannot be used in the context of the caller's application type."))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define APP_DEPRECATED_HRESULT HRESULT _WINAPI_DEPRECATED_DECLARATION
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define POINTER_64 __ptr64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define POINTER_32 __ptr32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define POINTER_64 __ptr64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define POINTER_64 __ptr64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define FIRMWARE_PTR POINTER_32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define POINTER_SIGNED __sptr
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define POINTER_UNSIGNED __uptr
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SPOINTER_32 POINTER_SIGNED POINTER_32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UPOINTER_32 POINTER_UNSIGNED POINTER_32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _W64 __w64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __int3264 __int64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __int3264 __int32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ADDRESS_TAG_BIT 0x40000000000UI64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToPtr64( p ) ((void * POINTER_64) p)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define Ptr64ToPtr( p ) ((void *) p)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HandleToHandle64( h ) (PtrToPtr64( h ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define Handle64ToHandle( h ) (Ptr64ToPtr( h ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HandleToHandle32( h ) (PtrToPtr32( h ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HandleToULong( h ) ((ULONG)(ULONG_PTR)(h) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HandleToLong( h ) ((LONG)(LONG_PTR) (h) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ULongToHandle( ul ) ((HANDLE)(ULONG_PTR) (ul) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LongToHandle( h ) ((HANDLE)(LONG_PTR) (h) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToUlong( p ) ((ULONG)(ULONG_PTR) (p) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToLong( p ) ((LONG)(LONG_PTR) (p) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToUint( p ) ((UINT)(UINT_PTR) (p) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToInt( p ) ((INT)(INT_PTR) (p) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToUshort( p ) ((unsigned short)(ULONG_PTR)(p) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToShort( p ) ((short)(LONG_PTR)(p) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define IntToPtr( LaniatusDefVariables ) ((VOID *)(INT_PTR)((int)i))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UIntToPtr( ui ) ((VOID *)(UINT_PTR)((unsigned int)ui))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LongToPtr( l ) ((VOID *)(LONG_PTR)((long)l))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ULongToPtr( ul ) ((VOID *)(ULONG_PTR)((unsigned long)ul))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define Ptr32ToPtr( p ) ((void *) p)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define Handle32ToHandle( h ) (Ptr32ToPtr( h ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PtrToPtr32( p ) ((void * POINTER_32) p)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HandleToHandle32( h ) (PtrToPtr32( h ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HandleToUlong(h) HandleToULong(h)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UlongToHandle(ul) ULongToHandle(ul)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UlongToPtr(ul) ULongToPtr(ul)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UintToPtr(ui) UIntToPtr(ui)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUINT_PTR (~((UINT_PTR)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXINT_PTR ((INT_PTR)(MAXUINT_PTR >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MININT_PTR (~MAXINT_PTR)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXULONG_PTR (~((ULONG_PTR)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXLONG_PTR ((LONG_PTR)(MAXULONG_PTR >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MINLONG_PTR (~MAXLONG_PTR)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUHALF_PTR ((UHALF_PTR)~0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXHALF_PTR ((HALF_PTR)(MAXUHALF_PTR >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MINHALF_PTR (~MAXHALF_PTR)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUINT8 ((UINT8)~((UINT8)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXINT8 ((INT8)(MAXUINT8 >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MININT8 ((INT8)~MAXINT8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUINT16 ((UINT16)~((UINT16)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXINT16 ((INT16)(MAXUINT16 >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MININT16 ((INT16)~MAXINT16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUINT32 ((UINT32)~((UINT32)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXINT32 ((INT32)(MAXUINT32 >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MININT32 ((INT32)~MAXINT32)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUINT64 ((UINT64)~((UINT64)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXINT64 ((INT64)(MAXUINT64 >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MININT64 ((INT64)~MAXINT64)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXULONG32 ((ULONG32)~((ULONG32)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXLONG32 ((LONG32)(MAXULONG32 >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MINLONG32 ((LONG32)~MAXLONG32)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXULONG64 ((ULONG64)~((ULONG64)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXLONG64 ((LONG64)(MAXULONG64 >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MINLONG64 ((LONG64)~MAXLONG64)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXULONGLONG ((ULONGLONG)~((ULONGLONG)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MINLONGLONG ((LONGLONG)~MAXLONGLONG)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXSIZE_T ((SIZE_T)~((SIZE_T)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXSSIZE_T ((SSIZE_T)(MAXSIZE_T >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MINSSIZE_T ((SSIZE_T)~MAXSSIZE_T)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXUINT ((UINT)~((UINT)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXINT ((INT)(MAXUINT >> 1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MININT ((INT)~MAXINT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXDWORD32 ((DWORD32)~((DWORD32)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAXDWORD64 ((DWORD64)~((DWORD64)0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midl_user_allocate MIDL_user_allocate
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midl_user_free MIDL_user_free
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DECLSPEC_IMPORT __declspec(dllimport)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RPCRTAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RPCNSAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RPCXCWORD (sizeof(jmp_buf)/sizeof(int))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DECLSPEC_NORETURN __declspec(noreturn)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_VERSION_SAL2(_A) SAL_2_Clean_Violation_using ## _A
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_VERSION_SAL2(_A)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_VERSION_CHECK(_A) _SAL_VERSION_SAL2(_A)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_VERSION_CHECK(_A)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SAL_VERSION_CHECK(_A) _SAL_VERSION_CHECK(_A)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SAL_VERSION_SAL2(_A) _SAL_VERSION_SAL2(_A)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_L_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "2") _Group_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_L_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "2") _GrouP_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL1_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "1") _GrouP_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL1_1_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "1.1") _GrouP_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL1_2_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "1.2") _GrouP_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL2_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "2") _GrouP_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_L_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "2") _GrouP_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL1_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "1") _Group_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL1_1_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "1.1") _Group_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL1_2_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "1.2") _Group_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL2_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "2") _Group_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_L_Source_(Name, args, annotes) _SA_annotes3(SAL_name, #Name, "", "2") _Group_(annotes _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_(target, annos) _At_impl_(target, annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_buffer_(target, iter, bound, annos) _At_buffer_impl_(target, iter, bound, annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _When_(expr, annos) _When_impl_(expr, annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Group_(annos) _Group_impl_(annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _GrouP_(annos) _GrouP_impl_(annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Success_(expr) _SAL2_Source_(_Success_, (expr), _Success_impl_(expr))
//# Laniatus Games Studio Inc. | TODO TASK: Conditional typedefs are not handled by # Laniatus Games Studio Inc. |:
//#define _Return_type_success_(expr) _SAL2_Source_(_Return_type_success_, (expr), _Success_impl_(expr))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _On_failure_(annos) _On_failure_impl_(annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Always_(annos) _Always_impl_(annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Use_decl_annotations_ _Use_decl_anno_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notref_ _Notref_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_defensive_ _SA_annotes0(SAL_pre_defensive)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_defensive_ _SA_annotes0(SAL_post_defensive)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_defensive_(annotes) _Pre_defensive_ _Group_(annotes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_defensive_(annotes) _Post_defensive_ _Group_(annotes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_defensive_(annotes) _Pre_defensive_ _Post_defensive_ _Group_(annotes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Reserved_ _SAL2_Source_(_Reserved_, (), _Pre1_impl_(__null_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Const_ _SAL2_Source_(_Const_, (), _Pre1_impl_(__readaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_ _SAL2_Source_(_In_, (), _Pre1_impl_(__notnull_impl_notref) _Pre_valid_impl_ _Deref_pre1_impl_(__readaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_ _SAL2_Source_(_In_opt_, (), _Pre1_impl_(__maybenull_impl_notref) _Pre_valid_impl_ _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_z_ _SAL2_Source_(_In_z_, (), _In_ _Pre1_impl_(__zterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_z_ _SAL2_Source_(_In_opt_z_, (), _In_opt_ _Pre1_impl_(__zterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_(size) _SAL2_Source_(_In_reads_, (size), _Pre_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_opt_(size) _SAL2_Source_(_In_reads_opt_, (size), _Pre_opt_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_bytes_(size) _SAL2_Source_(_In_reads_bytes_, (size), _Pre_bytecount_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_bytes_opt_(size) _SAL2_Source_(_In_reads_bytes_opt_, (size), _Pre_opt_bytecount_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_z_(size) _SAL2_Source_(_In_reads_z_, (size), _In_reads_(size) _Pre_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_opt_z_(size) _SAL2_Source_(_In_reads_opt_z_, (size), _Pre_opt_count_(size) _Deref_pre_readonly_ _Pre_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_or_z_(size) _SAL2_Source_(_In_reads_or_z_, (size), _In_ _When_(_String_length_(_Curr_) < (size), _Pre_z_) _When_(_String_length_(_Curr_) >= (size), _Pre1_impl_(__count_impl(size))))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_or_z_opt_(size) _SAL2_Source_(_In_reads_or_z_opt_, (size), _In_opt_ _When_(_String_length_(_Curr_) < (size), _Pre_z_) _When_(_String_length_(_Curr_) >= (size), _Pre1_impl_(__count_impl(size))))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_to_ptr_(ptr) _SAL2_Source_(_In_reads_to_ptr_, (ptr), _Pre_ptrdiff_count_(ptr) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_to_ptr_opt_(ptr) _SAL2_Source_(_In_reads_to_ptr_opt_, (ptr), _Pre_opt_ptrdiff_count_(ptr) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_to_ptr_z_(ptr) _SAL2_Source_(_In_reads_to_ptr_z_, (ptr), _In_reads_to_ptr_(ptr) _Pre_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_reads_to_ptr_opt_z_(ptr) _SAL2_Source_(_In_reads_to_ptr_opt_z_, (ptr), _Pre_opt_ptrdiff_count_(ptr) _Deref_pre_readonly_ _Pre_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_ _SAL2_Source_(_Out_, (), _Out_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_ _SAL2_Source_(_Out_opt_, (), _Out_opt_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_(size) _SAL2_Source_(_Out_writes_, (size), _Pre_cap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_opt_(size) _SAL2_Source_(_Out_writes_opt_, (size), _Pre_opt_cap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_bytes_(size) _SAL2_Source_(_Out_writes_bytes_, (size), _Pre_bytecap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_bytes_opt_(size) _SAL2_Source_(_Out_writes_bytes_opt_, (size), _Pre_opt_bytecap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_z_(size) _SAL2_Source_(_Out_writes_z_, (size), _Pre_cap_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_opt_z_(size) _SAL2_Source_(_Out_writes_opt_z_, (size), _Pre_opt_cap_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_to_(size,count) _SAL2_Source_(_Out_writes_to_, (size,count), _Pre_cap_(size) _Post_valid_impl_ _Post_count_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_to_opt_(size,count) _SAL2_Source_(_Out_writes_to_opt_, (size,count), _Pre_opt_cap_(size) _Post_valid_impl_ _Post_count_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_all_(size) _SAL2_Source_(_Out_writes_all_, (size), _Out_writes_to_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_all_opt_(size) _SAL2_Source_(_Out_writes_all_opt_, (size), _Out_writes_to_opt_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_bytes_to_(size,count) _SAL2_Source_(_Out_writes_bytes_to_, (size,count), _Pre_bytecap_(size) _Post_valid_impl_ _Post_bytecount_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_bytes_to_opt_(size,count) _SAL2_Source_(_Out_writes_bytes_to_opt_, (size,count), _Pre_opt_bytecap_(size) _Post_valid_impl_ _Post_bytecount_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_bytes_all_(size) _SAL2_Source_(_Out_writes_bytes_all_, (size), _Out_writes_bytes_to_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_bytes_all_opt_(size) _SAL2_Source_(_Out_writes_bytes_all_opt_, (size), _Out_writes_bytes_to_opt_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_to_ptr_(ptr) _SAL2_Source_(_Out_writes_to_ptr_, (ptr), _Pre_ptrdiff_cap_(ptr) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_to_ptr_opt_(ptr) _SAL2_Source_(_Out_writes_to_ptr_opt_, (ptr), _Pre_opt_ptrdiff_cap_(ptr) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_to_ptr_z_(ptr) _SAL2_Source_(_Out_writes_to_ptr_z_, (ptr), _Pre_ptrdiff_cap_(ptr) _Post_valid_impl_ Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_writes_to_ptr_opt_z_(ptr) _SAL2_Source_(_Out_writes_to_ptr_opt_z_, (ptr), _Pre_opt_ptrdiff_cap_(ptr) _Post_valid_impl_ Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_ _SAL2_Source_(_Inout_, (), _Prepost_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_ _SAL2_Source_(_Inout_opt_, (), _Prepost_opt_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_ _SAL2_Source_(_Inout_z_, (), _Prepost_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_ _SAL2_Source_(_Inout_opt_z_, (), _Prepost_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_(size) _SAL2_Source_(_Inout_updates_, (size), _Pre_cap_(size) _Pre_valid_impl_ _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_opt_(size) _SAL2_Source_(_Inout_updates_opt_, (size), _Pre_opt_cap_(size) _Pre_valid_impl_ _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_z_(size) _SAL2_Source_(_Inout_updates_z_, (size), _Pre_cap_(size) _Pre_valid_impl_ _Post_valid_impl_ _Pre1_impl_(__zterm_impl) _Post1_impl_(__zterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_opt_z_(size) _SAL2_Source_(_Inout_updates_opt_z_, (size), _Pre_opt_cap_(size) _Pre_valid_impl_ _Post_valid_impl_ _Pre1_impl_(__zterm_impl) _Post1_impl_(__zterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_to_(size,count) _SAL2_Source_(_Inout_updates_to_, (size,count), _Out_writes_to_(size,count) _Pre_valid_impl_ _Pre1_impl_(__count_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_to_opt_(size,count) _SAL2_Source_(_Inout_updates_to_opt_, (size,count), _Out_writes_to_opt_(size,count) _Pre_valid_impl_ _Pre1_impl_(__count_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_all_(size) _SAL2_Source_(_Inout_updates_all_, (size), _Inout_updates_to_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_all_opt_(size) _SAL2_Source_(_Inout_updates_all_opt_, (size), _Inout_updates_to_opt_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_bytes_(size) _SAL2_Source_(_Inout_updates_bytes_, (size), _Pre_bytecap_(size) _Pre_valid_impl_ _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_bytes_opt_(size) _SAL2_Source_(_Inout_updates_bytes_opt_, (size), _Pre_opt_bytecap_(size) _Pre_valid_impl_ _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_bytes_to_(size,count) _SAL2_Source_(_Inout_updates_bytes_to_, (size,count), _Out_writes_bytes_to_(size,count) _Pre_valid_impl_ _Pre1_impl_(__bytecount_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_bytes_to_opt_(size,count) _SAL2_Source_(_Inout_updates_bytes_to_opt_, (size,count), _Out_writes_bytes_to_opt_(size,count) _Pre_valid_impl_ _Pre1_impl_(__bytecount_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_bytes_all_(size) _SAL2_Source_(_Inout_updates_bytes_all_, (size), _Inout_updates_bytes_to_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_updates_bytes_all_opt_(size) _SAL2_Source_(_Inout_updates_bytes_all_opt_, (size), _Inout_updates_bytes_to_opt_(_Old_(size), _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_ _SAL2_Source_(_Outptr_, (), _Out_impl_ _Deref_post2_impl_(__notnull_impl_notref, __count_impl(1)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_maybenull_ _SAL2_Source_(_Outptr_result_maybenull_, (), _Out_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __count_impl(1)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_ _SAL2_Source_(_Outptr_opt_, (), _Out_opt_impl_ _Deref_post2_impl_(__notnull_impl_notref, __count_impl(1)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_maybenull_ _SAL2_Source_(_Outptr_opt_result_maybenull_, (), _Out_opt_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __count_impl(1)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_z_ _SAL2_Source_(_Outptr_result_z_, (), _Out_impl_ _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_z_ _SAL2_Source_(_Outptr_opt_result_z_, (), _Out_opt_impl_ _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_maybenull_z_ _SAL2_Source_(_Outptr_result_maybenull_z_, (), _Out_impl_ _Deref_post_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_maybenull_z_ _SAL2_Source_(_Outptr_opt_result_maybenull_z_, (), _Out_opt_impl_ _Deref_post_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_nullonfailure_ _SAL2_Source_(_Outptr_result_nullonfailure_, (), _Outptr_ _On_failure_(_Deref_post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_nullonfailure_ _SAL2_Source_(_Outptr_opt_result_nullonfailure_, (), _Outptr_opt_ _On_failure_(_Deref_post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _COM_Outptr_ _SAL2_Source_(_COM_Outptr_, (), _Outptr_ _On_failure_(_Deref_post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _COM_Outptr_result_maybenull_ _SAL2_Source_(_COM_Outptr_result_maybenull_, (), _Outptr_result_maybenull_ _On_failure_(_Deref_post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _COM_Outptr_opt_ _SAL2_Source_(_COM_Outptr_opt_, (), _Outptr_opt_ _On_failure_(_Deref_post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _COM_Outptr_opt_result_maybenull_ _SAL2_Source_(_COM_Outptr_opt_result_maybenull_, (), _Outptr_opt_result_maybenull_ _On_failure_(_Deref_post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_buffer_(size) _SAL2_Source_(_Outptr_result_buffer_, (size), _Out_impl_ _Deref_post2_impl_(__notnull_impl_notref, __cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_buffer_(size) _SAL2_Source_(_Outptr_opt_result_buffer_, (size), _Out_opt_impl_ _Deref_post2_impl_(__notnull_impl_notref, __cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_buffer_to_(size, count) _SAL2_Source_(_Outptr_result_buffer_to_, (size, count), _Out_impl_ _Deref_post3_impl_(__notnull_impl_notref, __cap_impl(size), __count_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_buffer_to_(size, count) _SAL2_Source_(_Outptr_opt_result_buffer_to_, (size, count), _Out_opt_impl_ _Deref_post3_impl_(__notnull_impl_notref, __cap_impl(size), __count_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_buffer_all_(size) _SAL2_Source_(_Outptr_result_buffer_all_, (size), _Out_impl_ _Deref_post2_impl_(__notnull_impl_notref, __count_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_buffer_all_(size) _SAL2_Source_(_Outptr_opt_result_buffer_all_, (size), _Out_opt_impl_ _Deref_post2_impl_(__notnull_impl_notref, __count_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_buffer_maybenull_(size) _SAL2_Source_(_Outptr_result_buffer_maybenull_, (size), _Out_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_buffer_maybenull_(size) _SAL2_Source_(_Outptr_opt_result_buffer_maybenull_, (size), _Out_opt_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_buffer_to_maybenull_(size, count) _SAL2_Source_(_Outptr_result_buffer_to_maybenull_, (size, count), _Out_impl_ _Deref_post3_impl_(__maybenull_impl_notref, __cap_impl(size), __count_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_buffer_to_maybenull_(size, count) _SAL2_Source_(_Outptr_opt_result_buffer_to_maybenull_, (size, count), _Out_opt_impl_ _Deref_post3_impl_(__maybenull_impl_notref, __cap_impl(size), __count_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_buffer_all_maybenull_(size) _SAL2_Source_(_Outptr_result_buffer_all_maybenull_, (size), _Out_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __count_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_buffer_all_maybenull_(size) _SAL2_Source_(_Outptr_opt_result_buffer_all_maybenull_, (size), _Out_opt_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __count_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_bytebuffer_(size) _SAL2_Source_(_Outptr_result_bytebuffer_, (size), _Out_impl_ _Deref_post2_impl_(__notnull_impl_notref, __bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_bytebuffer_(size) _SAL2_Source_(_Outptr_opt_result_bytebuffer_, (size), _Out_opt_impl_ _Deref_post2_impl_(__notnull_impl_notref, __bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_bytebuffer_to_(size, count) _SAL2_Source_(_Outptr_result_bytebuffer_to_, (size, count), _Out_impl_ _Deref_post3_impl_(__notnull_impl_notref, __bytecap_impl(size), __bytecount_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_bytebuffer_to_(size, count) _SAL2_Source_(_Outptr_opt_result_bytebuffer_to_, (size, count), _Out_opt_impl_ _Deref_post3_impl_(__notnull_impl_notref, __bytecap_impl(size), __bytecount_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_bytebuffer_all_(size) _SAL2_Source_(_Outptr_result_bytebuffer_all_, (size), _Out_impl_ _Deref_post2_impl_(__notnull_impl_notref, __bytecount_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_bytebuffer_all_(size) _SAL2_Source_(_Outptr_opt_result_bytebuffer_all_, (size), _Out_opt_impl_ _Deref_post2_impl_(__notnull_impl_notref, __bytecount_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_bytebuffer_maybenull_(size) _SAL2_Source_(_Outptr_result_bytebuffer_maybenull_, (size), _Out_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_bytebuffer_maybenull_(size) _SAL2_Source_(_Outptr_opt_result_bytebuffer_maybenull_, (size), _Out_opt_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_bytebuffer_to_maybenull_(size, count) _SAL2_Source_(_Outptr_result_bytebuffer_to_maybenull_, (size, count), _Out_impl_ _Deref_post3_impl_(__maybenull_impl_notref, __bytecap_impl(size), __bytecount_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_bytebuffer_to_maybenull_(size, count) _SAL2_Source_(_Outptr_opt_result_bytebuffer_to_maybenull_, (size, count), _Out_opt_impl_ _Deref_post3_impl_(__maybenull_impl_notref, __bytecap_impl(size), __bytecount_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_result_bytebuffer_all_maybenull_(size) _SAL2_Source_(_Outptr_result_bytebuffer_all_maybenull_, (size), _Out_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __bytecount_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outptr_opt_result_bytebuffer_all_maybenull_(size) _SAL2_Source_(_Outptr_opt_result_bytebuffer_all_maybenull_, (size), _Out_opt_impl_ _Deref_post2_impl_(__maybenull_impl_notref, __bytecount_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_ _SAL2_Source_(_Outref_, (), _Out_impl_ _Post_notnull_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_maybenull_ _SAL2_Source_(_Outref_result_maybenull_, (), _Pre2_impl_(__notnull_impl_notref, __cap_c_one_notref_impl) _Post_maybenull_ _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_buffer_(size) _SAL2_Source_(_Outref_result_buffer_, (size), _Outref_ _Post1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_bytebuffer_(size) _SAL2_Source_(_Outref_result_bytebuffer_, (size), _Outref_ _Post1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_buffer_to_(size, count) _SAL2_Source_(_Outref_result_buffer_to_, (size, count), _Outref_result_buffer_(size) _Post1_impl_(__count_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_bytebuffer_to_(size, count) _SAL2_Source_(_Outref_result_bytebuffer_to_, (size, count), _Outref_result_bytebuffer_(size) _Post1_impl_(__bytecount_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_buffer_all_(size) _SAL2_Source_(_Outref_result_buffer_all_, (size), _Outref_result_buffer_to_(size, _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_bytebuffer_all_(size) _SAL2_Source_(_Outref_result_bytebuffer_all_, (size), _Outref_result_bytebuffer_to_(size, _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_buffer_maybenull_(size) _SAL2_Source_(_Outref_result_buffer_maybenull_, (size), _Outref_result_maybenull_ _Post1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_bytebuffer_maybenull_(size) _SAL2_Source_(_Outref_result_bytebuffer_maybenull_, (size), _Outref_result_maybenull_ _Post1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_buffer_to_maybenull_(size, count) _SAL2_Source_(_Outref_result_buffer_to_maybenull_, (size, count), _Outref_result_buffer_maybenull_(size) _Post1_impl_(__count_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_bytebuffer_to_maybenull_(size, count) _SAL2_Source_(_Outref_result_bytebuffer_to_maybenull_, (size, count), _Outref_result_bytebuffer_maybenull_(size) _Post1_impl_(__bytecount_impl(count)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_buffer_all_maybenull_(size) _SAL2_Source_(_Outref_result_buffer_all_maybenull_, (size), _Outref_result_buffer_to_maybenull_(size, _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_bytebuffer_all_maybenull_(size) _SAL2_Source_(_Outref_result_bytebuffer_all_maybenull_, (size), _Outref_result_bytebuffer_to_maybenull_(size, _Old_(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Outref_result_nullonfailure_ _SAL2_Source_(_Outref_result_nullonfailure_, (), _Outref_ _On_failure_(_Post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Result_nullonfailure_ _SAL2_Source_(_Result_nullonfailure_, (), _On_failure_(_Notref_impl_ _Deref_impl_ _Post_null_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Result_zeroonfailure_ _SAL2_Source_(_Result_zeroonfailure_, (), _On_failure_(_Notref_impl_ _Deref_impl_ _Out_range_(==, 0)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_z_ _SAL2_Source_(_Ret_z_, (), _Ret2_impl_(__notnull_impl, __zterm_impl) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_maybenull_z_ _SAL2_Source_(_Ret_maybenull_z_, (), _Ret2_impl_(__maybenull_impl,__zterm_impl) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_notnull_ _SAL2_Source_(_Ret_notnull_, (), _Ret1_impl_(__notnull_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_maybenull_ _SAL2_Source_(_Ret_maybenull_, (), _Ret1_impl_(__maybenull_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_null_ _SAL2_Source_(_Ret_null_, (), _Ret1_impl_(__null_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_valid_ _SAL2_Source_(_Ret_valid_, (), _Ret1_impl_(__notnull_impl_notref) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_(size) _SAL2_Source_(_Ret_writes_, (size), _Ret2_impl_(__notnull_impl, __count_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_z_(size) _SAL2_Source_(_Ret_writes_z_, (size), _Ret3_impl_(__notnull_impl, __count_impl(size), __zterm_impl) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_bytes_(size) _SAL2_Source_(_Ret_writes_bytes_, (size), _Ret2_impl_(__notnull_impl, __bytecount_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_maybenull_(size) _SAL2_Source_(_Ret_writes_maybenull_, (size), _Ret2_impl_(__maybenull_impl,__count_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_maybenull_z_(size) _SAL2_Source_(_Ret_writes_maybenull_z_, (size), _Ret3_impl_(__maybenull_impl,__count_impl(size),__zterm_impl) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_bytes_maybenull_(size) _SAL2_Source_(_Ret_writes_bytes_maybenull_, (size), _Ret2_impl_(__maybenull_impl,__bytecount_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_to_(size,count) _SAL2_Source_(_Ret_writes_to_, (size,count), _Ret3_impl_(__notnull_impl, __cap_impl(size), __count_impl(count)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_bytes_to_(size,count) _SAL2_Source_(_Ret_writes_bytes_to_, (size,count), _Ret3_impl_(__notnull_impl, __bytecap_impl(size), __bytecount_impl(count)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_to_maybenull_(size,count) _SAL2_Source_(_Ret_writes_to_maybenull_, (size,count), _Ret3_impl_(__maybenull_impl, __cap_impl(size), __count_impl(count)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_writes_bytes_to_maybenull_(size,count) _SAL2_Source_(_Ret_writes_bytes_to_maybenull_, (size,count), _Ret3_impl_(__maybenull_impl, __bytecap_impl(size), __bytecount_impl(count)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Points_to_data_ _SAL2_Source_(_Points_to_data_, (), _Pre_ _Points_to_data_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Literal_ _SAL2_Source_(_Literal_, (), _Pre_ _Literal_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notliteral_ _SAL2_Source_(_Notliteral_, (), _Pre_ _Notliteral_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Check_return_ _SAL2_Source_(_Check_return_, (), _Check_return_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Must_inspect_result_ _SAL2_Source_(_Must_inspect_result_, (), _Must_inspect_impl_ _Check_return_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Printf_format_string_ _SAL2_Source_(_Printf_format_string_, (), _Printf_format_string_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_format_string_ _SAL2_Source_(_Scanf_format_string_, (), _Scanf_format_string_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_s_format_string_ _SAL2_Source_(_Scanf_s_format_string_, (), _Scanf_s_format_string_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Format_string_impl_(kind,where) _SA_annotes2(SAL_IsFormatString2, kind, where)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Printf_format_string_params_(x) _SAL2_Source_(_Printf_format_string_params_, (x), _Format_string_impl_("printf", x))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_format_string_params_(x) _SAL2_Source_(_Scanf_format_string_params_, (x), _Format_string_impl_("scanf", x))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_s_format_string_params_(x) _SAL2_Source_(_Scanf_s_format_string_params_, (x), _Format_string_impl_("scanf_s", x))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_range_(lb,ub) _SAL2_Source_(_In_range_, (lb,ub), _In_range_impl_(lb,ub))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_range_(lb,ub) _SAL2_Source_(_Out_range_, (lb,ub), _Out_range_impl_(lb,ub))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_range_(lb,ub) _SAL2_Source_(_Ret_range_, (lb,ub), _Ret_range_impl_(lb,ub))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_range_(lb,ub) _SAL2_Source_(_Deref_in_range_, (lb,ub), _Deref_in_range_impl_(lb,ub))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_range_(lb,ub) _SAL2_Source_(_Deref_out_range_, (lb,ub), _Deref_out_range_impl_(lb,ub))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_range_(lb,ub) _SAL2_Source_(_Deref_ret_range_, (lb,ub), _Deref_ret_range_impl_(lb,ub))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_equal_to_(expr) _SAL2_Source_(_Pre_equal_to_, (expr), _In_range_(==, expr))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_equal_to_(expr) _SAL2_Source_(_Post_equal_to_, (expr), _Out_range_(==, expr))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Unchanged_(e) _SAL2_Source_(_Unchanged_, (e), _At_(e, _Post_equal_to_(_Old_(e)) _Const_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_satisfies_(cond) _SAL2_Source_(_Pre_satisfies_, (cond), _Pre_satisfies_impl_(cond))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_satisfies_(cond) _SAL2_Source_(_Post_satisfies_, (cond), _Post_satisfies_impl_(cond))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Struct_size_bytes_(size) _SAL2_Source_(_Struct_size_bytes_, (size), _Writable_bytes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_(size) _SAL2_Source_(_Field_size_, (size), _Notnull_ _Writable_elements_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_opt_(size) _SAL2_Source_(_Field_size_opt_, (size), _Maybenull_ _Writable_elements_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_part_(size, count) _SAL2_Source_(_Field_size_part_, (size, count), _Notnull_ _Writable_elements_(size) _Readable_elements_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_part_opt_(size, count) _SAL2_Source_(_Field_size_part_opt_, (size, count), _Maybenull_ _Writable_elements_(size) _Readable_elements_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_full_(size) _SAL2_Source_(_Field_size_full_, (size), _Field_size_part_(size, size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_full_opt_(size) _SAL2_Source_(_Field_size_full_opt_, (size), _Field_size_part_opt_(size, size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_bytes_(size) _SAL2_Source_(_Field_size_bytes_, (size), _Notnull_ _Writable_bytes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_bytes_opt_(size) _SAL2_Source_(_Field_size_bytes_opt_, (size), _Maybenull_ _Writable_bytes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_bytes_part_(size, count) _SAL2_Source_(_Field_size_bytes_part_, (size, count), _Notnull_ _Writable_bytes_(size) _Readable_bytes_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_bytes_part_opt_(size, count) _SAL2_Source_(_Field_size_bytes_part_opt_, (size, count), _Maybenull_ _Writable_bytes_(size) _Readable_bytes_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_bytes_full_(size) _SAL2_Source_(_Field_size_bytes_full_, (size), _Field_size_bytes_part_(size, size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_size_bytes_full_opt_(size) _SAL2_Source_(_Field_size_bytes_full_opt_, (size), _Field_size_bytes_part_opt_(size, size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_z_ _SAL2_Source_(_Field_z_, (), _Null_terminated_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_range_(min,max) _SAL2_Source_(_Field_range_, (min,max), _Field_range_impl_(min,max))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_ _Pre_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_ _Post_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Valid_ _Valid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notvalid_ _Notvalid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybevalid_ _Maybevalid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_bytes_(size) _SAL2_Source_(_Readable_bytes_, (size), _Readable_bytes_impl_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_elements_(size) _SAL2_Source_(_Readable_elements_, (size), _Readable_elements_impl_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_bytes_(size) _SAL2_Source_(_Writable_bytes_, (size), _Writable_bytes_impl_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_elements_(size) _SAL2_Source_(_Writable_elements_, (size), _Writable_elements_impl_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Null_terminated_ _SAL2_Source_(_Null_terminated_, (), _Null_terminated_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _NullNull_terminated_ _SAL2_Source_(_NullNull_terminated_, (), _NullNull_terminated_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_readable_size_(size) _SAL2_Source_(_Pre_readable_size_, (size), _Pre1_impl_(__count_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_writable_size_(size) _SAL2_Source_(_Pre_writable_size_, (size), _Pre1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_readable_byte_size_(size) _SAL2_Source_(_Pre_readable_byte_size_, (size), _Pre1_impl_(__bytecount_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_writable_byte_size_(size) _SAL2_Source_(_Pre_writable_byte_size_, (size), _Pre1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_readable_size_(size) _SAL2_Source_(_Post_readable_size_, (size), _Post1_impl_(__count_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_writable_size_(size) _SAL2_Source_(_Post_writable_size_, (size), _Post1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_readable_byte_size_(size) _SAL2_Source_(_Post_readable_byte_size_, (size), _Post1_impl_(__bytecount_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_writable_byte_size_(size) _SAL2_Source_(_Post_writable_byte_size_, (size), _Post1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Null_ _SAL2_Source_(_Null_, (), _Null_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notnull_ _SAL2_Source_(_Notnull_, (), _Notnull_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybenull_ _SAL2_Source_(_Maybenull_, (), _Maybenull_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_ _SAL2_Source_(_Pre_z_, (), _Pre1_impl_(__zterm_impl) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_ _SAL2_Source_(_Pre_valid_, (), _Pre1_impl_(__notnull_impl_notref) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_ _SAL2_Source_(_Pre_opt_valid_, (), _Pre1_impl_(__maybenull_impl_notref) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_invalid_ _SAL2_Source_(_Pre_invalid_, (), _Deref_pre1_impl_(__notvalid_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_unknown_ _SAL2_Source_(_Pre_unknown_, (), _Pre1_impl_(__maybevalid_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_notnull_ _SAL2_Source_(_Pre_notnull_, (), _Pre1_impl_(__notnull_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_maybenull_ _SAL2_Source_(_Pre_maybenull_, (), _Pre1_impl_(__maybenull_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_null_ _SAL2_Source_(_Pre_null_, (), _Pre1_impl_(__null_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_ _SAL2_Source_(_Post_z_, (), _Post1_impl_(__zterm_impl) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_valid_ _SAL2_Source_(_Post_valid_, (), _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_invalid_ _SAL2_Source_(_Post_invalid_, (), _Deref_post1_impl_(__notvalid_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_ptr_invalid_ _SAL2_Source_(_Post_ptr_invalid_, (), _Post1_impl_(__notvalid_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_notnull_ _SAL2_Source_(_Post_notnull_, (), _Post1_impl_(__notnull_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_null_ _SAL2_Source_(_Post_null_, (), _Post1_impl_(__null_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_maybenull_ _SAL2_Source_(_Post_maybenull_, (), _Post1_impl_(__maybenull_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_z_ _SAL2_Source_(_Prepost_z_, (), _Pre_z_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_count_(size) _SAL1_1_Source_(_In_count_, (size), _Pre_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_count_(size) _SAL1_1_Source_(_In_opt_count_, (size), _Pre_opt_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bytecount_(size) _SAL1_1_Source_(_In_bytecount_, (size), _Pre_bytecount_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_bytecount_(size) _SAL1_1_Source_(_In_opt_bytecount_, (size), _Pre_opt_bytecount_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_count_c_(size) _SAL1_1_Source_(_In_count_c_, (size), _Pre_count_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_count_c_(size) _SAL1_1_Source_(_In_opt_count_c_, (size), _Pre_opt_count_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bytecount_c_(size) _SAL1_1_Source_(_In_bytecount_c_, (size), _Pre_bytecount_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_bytecount_c_(size) _SAL1_1_Source_(_In_opt_bytecount_c_, (size), _Pre_opt_bytecount_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_z_count_(size) _SAL1_1_Source_(_In_z_count_, (size), _Pre_z_ _Pre_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_z_count_(size) _SAL1_1_Source_(_In_opt_z_count_, (size), _Pre_opt_z_ _Pre_opt_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_z_bytecount_(size) _SAL1_1_Source_(_In_z_bytecount_, (size), _Pre_z_ _Pre_bytecount_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_z_bytecount_(size) _SAL1_1_Source_(_In_opt_z_bytecount_, (size), _Pre_opt_z_ _Pre_opt_bytecount_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_z_count_c_(size) _SAL1_1_Source_(_In_z_count_c_, (size), _Pre_z_ _Pre_count_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_z_count_c_(size) _SAL1_1_Source_(_In_opt_z_count_c_, (size), _Pre_opt_z_ _Pre_opt_count_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_z_bytecount_c_(size) _SAL1_1_Source_(_In_z_bytecount_c_, (size), _Pre_z_ _Pre_bytecount_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_z_bytecount_c_(size) _SAL1_1_Source_(_In_opt_z_bytecount_c_, (size), _Pre_opt_z_ _Pre_opt_bytecount_c_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_ptrdiff_count_(size) _SAL1_1_Source_(_In_ptrdiff_count_, (size), _Pre_ptrdiff_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_ptrdiff_count_(size) _SAL1_1_Source_(_In_opt_ptrdiff_count_, (size), _Pre_opt_ptrdiff_count_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_count_x_(size) _SAL1_1_Source_(_In_count_x_, (size), _Pre_count_x_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_count_x_(size) _SAL1_1_Source_(_In_opt_count_x_, (size), _Pre_opt_count_x_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bytecount_x_(size) _SAL1_1_Source_(_In_bytecount_x_, (size), _Pre_bytecount_x_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_opt_bytecount_x_(size) _SAL1_1_Source_(_In_opt_bytecount_x_, (size), _Pre_opt_bytecount_x_(size) _Deref_pre_readonly_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_cap_(size) _SAL1_1_Source_(_Out_cap_, (size), _Pre_cap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_cap_(size) _SAL1_1_Source_(_Out_opt_cap_, (size), _Pre_opt_cap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bytecap_(size) _SAL1_1_Source_(_Out_bytecap_, (size), _Pre_bytecap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_bytecap_(size) _SAL1_1_Source_(_Out_opt_bytecap_, (size), _Pre_opt_bytecap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_cap_c_(size) _SAL1_1_Source_(_Out_cap_c_, (size), _Pre_cap_c_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_cap_c_(size) _SAL1_1_Source_(_Out_opt_cap_c_, (size), _Pre_opt_cap_c_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bytecap_c_(size) _SAL1_1_Source_(_Out_bytecap_c_, (size), _Pre_bytecap_c_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_bytecap_c_(size) _SAL1_1_Source_(_Out_opt_bytecap_c_, (size), _Pre_opt_bytecap_c_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_cap_m_(mult,size) _SAL1_1_Source_(_Out_cap_m_, (mult,size), _Pre_cap_m_(mult,size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_cap_m_(mult,size) _SAL1_1_Source_(_Out_opt_cap_m_, (mult,size), _Pre_opt_cap_m_(mult,size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_cap_m_(mult,size) _SAL1_1_Source_(_Out_z_cap_m_, (mult,size), _Pre_cap_m_(mult,size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_cap_m_(mult,size) _SAL1_1_Source_(_Out_opt_z_cap_m_, (mult,size), _Pre_opt_cap_m_(mult,size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_ptrdiff_cap_(size) _SAL1_1_Source_(_Out_ptrdiff_cap_, (size), _Pre_ptrdiff_cap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_ptrdiff_cap_(size) _SAL1_1_Source_(_Out_opt_ptrdiff_cap_, (size), _Pre_opt_ptrdiff_cap_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_cap_x_(size) _SAL1_1_Source_(_Out_cap_x_, (size), _Pre_cap_x_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_cap_x_(size) _SAL1_1_Source_(_Out_opt_cap_x_, (size), _Pre_opt_cap_x_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bytecap_x_(size) _SAL1_1_Source_(_Out_bytecap_x_, (size), _Pre_bytecap_x_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_bytecap_x_(size) _SAL1_1_Source_(_Out_opt_bytecap_x_, (size), _Pre_opt_bytecap_x_(size) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_cap_(size) _SAL1_1_Source_(_Out_z_cap_, (size), _Pre_cap_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_cap_(size) _SAL1_1_Source_(_Out_opt_z_cap_, (size), _Pre_opt_cap_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_bytecap_(size) _SAL1_1_Source_(_Out_z_bytecap_, (size), _Pre_bytecap_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_bytecap_(size) _SAL1_1_Source_(_Out_opt_z_bytecap_, (size), _Pre_opt_bytecap_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_cap_c_(size) _SAL1_1_Source_(_Out_z_cap_c_, (size), _Pre_cap_c_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_cap_c_(size) _SAL1_1_Source_(_Out_opt_z_cap_c_, (size), _Pre_opt_cap_c_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_bytecap_c_(size) _SAL1_1_Source_(_Out_z_bytecap_c_, (size), _Pre_bytecap_c_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_bytecap_c_(size) _SAL1_1_Source_(_Out_opt_z_bytecap_c_, (size), _Pre_opt_bytecap_c_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_cap_x_(size) _SAL1_1_Source_(_Out_z_cap_x_, (size), _Pre_cap_x_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_cap_x_(size) _SAL1_1_Source_(_Out_opt_z_cap_x_, (size), _Pre_opt_cap_x_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_bytecap_x_(size) _SAL1_1_Source_(_Out_z_bytecap_x_, (size), _Pre_bytecap_x_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_bytecap_x_(size) _SAL1_1_Source_(_Out_opt_z_bytecap_x_, (size), _Pre_opt_bytecap_x_(size) _Post_valid_impl_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_cap_post_count_(cap,count) _SAL1_1_Source_(_Out_cap_post_count_, (cap,count), _Pre_cap_(cap) _Post_valid_impl_ _Post_count_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_cap_post_count_(cap,count) _SAL1_1_Source_(_Out_opt_cap_post_count_, (cap,count), _Pre_opt_cap_(cap) _Post_valid_impl_ _Post_count_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bytecap_post_bytecount_(cap,count) _SAL1_1_Source_(_Out_bytecap_post_bytecount_, (cap,count), _Pre_bytecap_(cap) _Post_valid_impl_ _Post_bytecount_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_bytecap_post_bytecount_(cap,count) _SAL1_1_Source_(_Out_opt_bytecap_post_bytecount_, (cap,count), _Pre_opt_bytecap_(cap) _Post_valid_impl_ _Post_bytecount_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_cap_post_count_(cap,count) _SAL1_1_Source_(_Out_z_cap_post_count_, (cap,count), _Pre_cap_(cap) _Post_valid_impl_ _Post_z_count_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_cap_post_count_(cap,count) _SAL1_1_Source_(_Out_opt_z_cap_post_count_, (cap,count), _Pre_opt_cap_(cap) _Post_valid_impl_ _Post_z_count_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_bytecap_post_bytecount_(cap,count) _SAL1_1_Source_(_Out_z_bytecap_post_bytecount_, (cap,count), _Pre_bytecap_(cap) _Post_valid_impl_ _Post_z_bytecount_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_bytecap_post_bytecount_(cap,count) _SAL1_1_Source_(_Out_opt_z_bytecap_post_bytecount_, (cap,count), _Pre_opt_bytecap_(cap) _Post_valid_impl_ _Post_z_bytecount_(count))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_capcount_(capcount) _SAL1_1_Source_(_Out_capcount_, (capcount), _Pre_cap_(capcount) _Post_valid_impl_ _Post_count_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_capcount_(capcount) _SAL1_1_Source_(_Out_opt_capcount_, (capcount), _Pre_opt_cap_(capcount) _Post_valid_impl_ _Post_count_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bytecapcount_(capcount) _SAL1_1_Source_(_Out_bytecapcount_, (capcount), _Pre_bytecap_(capcount) _Post_valid_impl_ _Post_bytecount_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_bytecapcount_(capcount) _SAL1_1_Source_(_Out_opt_bytecapcount_, (capcount), _Pre_opt_bytecap_(capcount) _Post_valid_impl_ _Post_bytecount_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_capcount_x_(capcount) _SAL1_1_Source_(_Out_capcount_x_, (capcount), _Pre_cap_x_(capcount) _Post_valid_impl_ _Post_count_x_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_capcount_x_(capcount) _SAL1_1_Source_(_Out_opt_capcount_x_, (capcount), _Pre_opt_cap_x_(capcount) _Post_valid_impl_ _Post_count_x_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bytecapcount_x_(capcount) _SAL1_1_Source_(_Out_bytecapcount_x_, (capcount), _Pre_bytecap_x_(capcount) _Post_valid_impl_ _Post_bytecount_x_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_bytecapcount_x_(capcount) _SAL1_1_Source_(_Out_opt_bytecapcount_x_, (capcount), _Pre_opt_bytecap_x_(capcount) _Post_valid_impl_ _Post_bytecount_x_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_capcount_(capcount) _SAL1_1_Source_(_Out_z_capcount_, (capcount), _Pre_cap_(capcount) _Post_valid_impl_ _Post_z_count_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_capcount_(capcount) _SAL1_1_Source_(_Out_opt_z_capcount_, (capcount), _Pre_opt_cap_(capcount) _Post_valid_impl_ _Post_z_count_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_z_bytecapcount_(capcount) _SAL1_1_Source_(_Out_z_bytecapcount_, (capcount), _Pre_bytecap_(capcount) _Post_valid_impl_ _Post_z_bytecount_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_z_bytecapcount_(capcount) _SAL1_1_Source_(_Out_opt_z_bytecapcount_, (capcount), _Pre_opt_bytecap_(capcount) _Post_valid_impl_ _Post_z_bytecount_(capcount))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_count_(size) _SAL1_1_Source_(_Inout_count_, (size), _Prepost_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_count_(size) _SAL1_1_Source_(_Inout_opt_count_, (size), _Prepost_opt_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_bytecount_(size) _SAL1_1_Source_(_Inout_bytecount_, (size), _Prepost_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_bytecount_(size) _SAL1_1_Source_(_Inout_opt_bytecount_, (size), _Prepost_opt_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_count_c_(size) _SAL1_1_Source_(_Inout_count_c_, (size), _Prepost_count_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_count_c_(size) _SAL1_1_Source_(_Inout_opt_count_c_, (size), _Prepost_opt_count_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_bytecount_c_(size) _SAL1_1_Source_(_Inout_bytecount_c_, (size), _Prepost_bytecount_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_bytecount_c_(size) _SAL1_1_Source_(_Inout_opt_bytecount_c_, (size), _Prepost_opt_bytecount_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_count_(size) _SAL1_1_Source_(_Inout_z_count_, (size), _Prepost_z_ _Prepost_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_count_(size) _SAL1_1_Source_(_Inout_opt_z_count_, (size), _Prepost_z_ _Prepost_opt_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_bytecount_(size) _SAL1_1_Source_(_Inout_z_bytecount_, (size), _Prepost_z_ _Prepost_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_bytecount_(size) _SAL1_1_Source_(_Inout_opt_z_bytecount_, (size), _Prepost_z_ _Prepost_opt_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_count_c_(size) _SAL1_1_Source_(_Inout_z_count_c_, (size), _Prepost_z_ _Prepost_count_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_count_c_(size) _SAL1_1_Source_(_Inout_opt_z_count_c_, (size), _Prepost_z_ _Prepost_opt_count_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_bytecount_c_(size) _SAL1_1_Source_(_Inout_z_bytecount_c_, (size), _Prepost_z_ _Prepost_bytecount_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_bytecount_c_(size) _SAL1_1_Source_(_Inout_opt_z_bytecount_c_, (size), _Prepost_z_ _Prepost_opt_bytecount_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_ptrdiff_count_(size) _SAL1_1_Source_(_Inout_ptrdiff_count_, (size), _Pre_ptrdiff_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_ptrdiff_count_(size) _SAL1_1_Source_(_Inout_opt_ptrdiff_count_, (size), _Pre_opt_ptrdiff_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_count_x_(size) _SAL1_1_Source_(_Inout_count_x_, (size), _Prepost_count_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_count_x_(size) _SAL1_1_Source_(_Inout_opt_count_x_, (size), _Prepost_opt_count_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_bytecount_x_(size) _SAL1_1_Source_(_Inout_bytecount_x_, (size), _Prepost_bytecount_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_bytecount_x_(size) _SAL1_1_Source_(_Inout_opt_bytecount_x_, (size), _Prepost_opt_bytecount_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_cap_(size) _SAL1_1_Source_(_Inout_cap_, (size), _Pre_valid_cap_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_cap_(size) _SAL1_1_Source_(_Inout_opt_cap_, (size), _Pre_opt_valid_cap_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_bytecap_(size) _SAL1_1_Source_(_Inout_bytecap_, (size), _Pre_valid_bytecap_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_bytecap_(size) _SAL1_1_Source_(_Inout_opt_bytecap_, (size), _Pre_opt_valid_bytecap_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_cap_c_(size) _SAL1_1_Source_(_Inout_cap_c_, (size), _Pre_valid_cap_c_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_cap_c_(size) _SAL1_1_Source_(_Inout_opt_cap_c_, (size), _Pre_opt_valid_cap_c_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_bytecap_c_(size) _SAL1_1_Source_(_Inout_bytecap_c_, (size), _Pre_valid_bytecap_c_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_bytecap_c_(size) _SAL1_1_Source_(_Inout_opt_bytecap_c_, (size), _Pre_opt_valid_bytecap_c_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_cap_x_(size) _SAL1_1_Source_(_Inout_cap_x_, (size), _Pre_valid_cap_x_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_cap_x_(size) _SAL1_1_Source_(_Inout_opt_cap_x_, (size), _Pre_opt_valid_cap_x_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_bytecap_x_(size) _SAL1_1_Source_(_Inout_bytecap_x_, (size), _Pre_valid_bytecap_x_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_bytecap_x_(size) _SAL1_1_Source_(_Inout_opt_bytecap_x_, (size), _Pre_opt_valid_bytecap_x_(size) _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_cap_(size) _SAL1_1_Source_(_Inout_z_cap_, (size), _Pre_z_cap_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_cap_(size) _SAL1_1_Source_(_Inout_opt_z_cap_, (size), _Pre_opt_z_cap_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_bytecap_(size) _SAL1_1_Source_(_Inout_z_bytecap_, (size), _Pre_z_bytecap_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_bytecap_(size) _SAL1_1_Source_(_Inout_opt_z_bytecap_, (size), _Pre_opt_z_bytecap_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_cap_c_(size) _SAL1_1_Source_(_Inout_z_cap_c_, (size), _Pre_z_cap_c_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_cap_c_(size) _SAL1_1_Source_(_Inout_opt_z_cap_c_, (size), _Pre_opt_z_cap_c_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_bytecap_c_(size) _SAL1_1_Source_(_Inout_z_bytecap_c_, (size), _Pre_z_bytecap_c_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_bytecap_c_(size) _SAL1_1_Source_(_Inout_opt_z_bytecap_c_, (size), _Pre_opt_z_bytecap_c_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_cap_x_(size) _SAL1_1_Source_(_Inout_z_cap_x_, (size), _Pre_z_cap_x_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_cap_x_(size) _SAL1_1_Source_(_Inout_opt_z_cap_x_, (size), _Pre_opt_z_cap_x_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_z_bytecap_x_(size) _SAL1_1_Source_(_Inout_z_bytecap_x_, (size), _Pre_z_bytecap_x_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Inout_opt_z_bytecap_x_(size) _SAL1_1_Source_(_Inout_opt_z_bytecap_x_, (size), _Pre_opt_z_bytecap_x_(size) _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_ _SAL1_1_Source_(_Ret_, (), _Ret_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_ _SAL1_1_Source_(_Ret_opt_, (), _Ret_opt_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bound_ _SAL1_1_Source_(_In_bound_, (), _In_bound_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bound_ _SAL1_1_Source_(_Out_bound_, (), _Out_bound_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bound_ _SAL1_1_Source_(_Ret_bound_, (), _Ret_bound_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_bound_ _SAL1_1_Source_(_Deref_in_bound_, (), _Deref_in_bound_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_bound_ _SAL1_1_Source_(_Deref_out_bound_, (), _Deref_out_bound_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_inout_bound_ _SAL1_1_Source_(_Deref_inout_bound_, (), _Deref_in_bound_ _Deref_out_bound_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_bound_ _SAL1_1_Source_(_Deref_ret_bound_, (), _Deref_ret_bound_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_ _SAL1_1_Source_(_Deref_out_, (), _Out_ _Deref_post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_opt_ _SAL1_1_Source_(_Deref_out_opt_, (), _Out_ _Deref_post_opt_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_opt_out_ _SAL1_1_Source_(_Deref_opt_out_, (), _Out_opt_ _Deref_post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_opt_out_opt_ _SAL1_1_Source_(_Deref_opt_out_opt_, (), _Out_opt_ _Deref_post_opt_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_z_ _SAL1_1_Source_(_Deref_out_z_, (), _Out_ _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_opt_z_ _SAL1_1_Source_(_Deref_out_opt_z_, (), _Out_ _Deref_post_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_opt_out_z_ _SAL1_1_Source_(_Deref_opt_out_z_, (), _Out_opt_ _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_opt_out_opt_z_ _SAL1_1_Source_(_Deref_opt_out_opt_z_, (), _Out_opt_ _Deref_post_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_ _SAL1_1_Source_(_Deref_pre_z_, (), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__zterm_impl) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_ _SAL1_1_Source_(_Deref_pre_opt_z_, (), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__zterm_impl) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_cap_(size) _SAL1_1_Source_(_Deref_pre_cap_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_cap_(size) _SAL1_1_Source_(_Deref_pre_opt_cap_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_bytecap_(size) _SAL1_1_Source_(_Deref_pre_bytecap_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_bytecap_(size) _SAL1_1_Source_(_Deref_pre_opt_bytecap_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_cap_c_(size) _SAL1_1_Source_(_Deref_pre_cap_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_cap_c_(size) _SAL1_1_Source_(_Deref_pre_opt_cap_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_bytecap_c_(size) _SAL1_1_Source_(_Deref_pre_bytecap_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_bytecap_c_(size) _SAL1_1_Source_(_Deref_pre_opt_bytecap_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_cap_x_(size) _SAL1_1_Source_(_Deref_pre_cap_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_cap_x_(size) _SAL1_1_Source_(_Deref_pre_opt_cap_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_bytecap_x_(size) _SAL1_1_Source_(_Deref_pre_bytecap_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_bytecap_x_(size) _SAL1_1_Source_(_Deref_pre_opt_bytecap_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_cap_(size) _SAL1_1_Source_(_Deref_pre_z_cap_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_cap_(size) _SAL1_1_Source_(_Deref_pre_opt_z_cap_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_bytecap_(size) _SAL1_1_Source_(_Deref_pre_z_bytecap_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_bytecap_(size) _SAL1_1_Source_(_Deref_pre_opt_z_bytecap_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_cap_c_(size) _SAL1_1_Source_(_Deref_pre_z_cap_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_cap_c_(size) _SAL1_1_Source_(_Deref_pre_opt_z_cap_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_bytecap_c_(size) _SAL1_1_Source_(_Deref_pre_z_bytecap_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_bytecap_c_(size) _SAL1_1_Source_(_Deref_pre_opt_z_bytecap_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_cap_x_(size) _SAL1_1_Source_(_Deref_pre_z_cap_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_cap_x_(size) _SAL1_1_Source_(_Deref_pre_opt_z_cap_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_z_bytecap_x_(size) _SAL1_1_Source_(_Deref_pre_z_bytecap_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_z_bytecap_x_(size) _SAL1_1_Source_(_Deref_pre_opt_z_bytecap_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre2_impl_(__zterm_impl,__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_cap_(size) _SAL1_1_Source_(_Deref_pre_valid_cap_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_cap_(size) _SAL1_1_Source_(_Deref_pre_opt_valid_cap_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_bytecap_(size) _SAL1_1_Source_(_Deref_pre_valid_bytecap_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_bytecap_(size) _SAL1_1_Source_(_Deref_pre_opt_valid_bytecap_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_cap_c_(size) _SAL1_1_Source_(_Deref_pre_valid_cap_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_cap_c_(size) _SAL1_1_Source_(_Deref_pre_opt_valid_cap_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_bytecap_c_(size) _SAL1_1_Source_(_Deref_pre_valid_bytecap_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_bytecap_c_(size) _SAL1_1_Source_(_Deref_pre_opt_valid_bytecap_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_cap_x_(size) _SAL1_1_Source_(_Deref_pre_valid_cap_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_cap_x_(size) _SAL1_1_Source_(_Deref_pre_opt_valid_cap_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_bytecap_x_(size) _SAL1_1_Source_(_Deref_pre_valid_bytecap_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_bytecap_x_(size) _SAL1_1_Source_(_Deref_pre_opt_valid_bytecap_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_count_(size) _SAL1_1_Source_(_Deref_pre_count_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__count_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_count_(size) _SAL1_1_Source_(_Deref_pre_opt_count_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__count_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_bytecount_(size) _SAL1_1_Source_(_Deref_pre_bytecount_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecount_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_bytecount_(size) _SAL1_1_Source_(_Deref_pre_opt_bytecount_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecount_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_count_c_(size) _SAL1_1_Source_(_Deref_pre_count_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__count_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_count_c_(size) _SAL1_1_Source_(_Deref_pre_opt_count_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__count_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_bytecount_c_(size) _SAL1_1_Source_(_Deref_pre_bytecount_c_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecount_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_bytecount_c_(size) _SAL1_1_Source_(_Deref_pre_opt_bytecount_c_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecount_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_count_x_(size) _SAL1_1_Source_(_Deref_pre_count_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__count_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_count_x_(size) _SAL1_1_Source_(_Deref_pre_opt_count_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__count_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_bytecount_x_(size) _SAL1_1_Source_(_Deref_pre_bytecount_x_, (size), _Deref_pre1_impl_(__notnull_impl_notref) _Deref_pre1_impl_(__bytecount_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_bytecount_x_(size) _SAL1_1_Source_(_Deref_pre_opt_bytecount_x_, (size), _Deref_pre1_impl_(__maybenull_impl_notref) _Deref_pre1_impl_(__bytecount_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_valid_ _SAL1_1_Source_(_Deref_pre_valid_, (), _Deref_pre1_impl_(__notnull_impl_notref) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_opt_valid_ _SAL1_1_Source_(_Deref_pre_opt_valid_, (), _Deref_pre1_impl_(__maybenull_impl_notref) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_invalid_ _SAL1_1_Source_(_Deref_pre_invalid_, (), _Deref_pre1_impl_(__notvalid_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_notnull_ _SAL1_1_Source_(_Deref_pre_notnull_, (), _Deref_pre1_impl_(__notnull_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_maybenull_ _SAL1_1_Source_(_Deref_pre_maybenull_, (), _Deref_pre1_impl_(__maybenull_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_null_ _SAL1_1_Source_(_Deref_pre_null_, (), _Deref_pre1_impl_(__null_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_readonly_ _SAL1_1_Source_(_Deref_pre_readonly_, (), _Deref_pre1_impl_(__readaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_writeonly_ _SAL1_1_Source_(_Deref_pre_writeonly_, (), _Deref_pre1_impl_(__writeaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_ _SAL1_1_Source_(_Deref_post_z_, (), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__zterm_impl) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_ _SAL1_1_Source_(_Deref_post_opt_z_, (), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__zterm_impl) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_cap_(size) _SAL1_1_Source_(_Deref_post_cap_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_cap_(size) _SAL1_1_Source_(_Deref_post_opt_cap_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_bytecap_(size) _SAL1_1_Source_(_Deref_post_bytecap_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_bytecap_(size) _SAL1_1_Source_(_Deref_post_opt_bytecap_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_cap_c_(size) _SAL1_1_Source_(_Deref_post_cap_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_cap_c_(size) _SAL1_1_Source_(_Deref_post_opt_cap_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_bytecap_c_(size) _SAL1_1_Source_(_Deref_post_bytecap_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_bytecap_c_(size) _SAL1_1_Source_(_Deref_post_opt_bytecap_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_cap_x_(size) _SAL1_1_Source_(_Deref_post_cap_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_cap_x_(size) _SAL1_1_Source_(_Deref_post_opt_cap_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_bytecap_x_(size) _SAL1_1_Source_(_Deref_post_bytecap_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_bytecap_x_(size) _SAL1_1_Source_(_Deref_post_opt_bytecap_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_cap_(size) _SAL1_1_Source_(_Deref_post_z_cap_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post2_impl_(__zterm_impl,__cap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_cap_(size) _SAL1_1_Source_(_Deref_post_opt_z_cap_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post2_impl_(__zterm_impl,__cap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_bytecap_(size) _SAL1_1_Source_(_Deref_post_z_bytecap_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post2_impl_(__zterm_impl,__bytecap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_bytecap_(size) _SAL1_1_Source_(_Deref_post_opt_z_bytecap_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post2_impl_(__zterm_impl,__bytecap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_cap_c_(size) _SAL1_1_Source_(_Deref_post_z_cap_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post2_impl_(__zterm_impl,__cap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_cap_c_(size) _SAL1_1_Source_(_Deref_post_opt_z_cap_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post2_impl_(__zterm_impl,__cap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_bytecap_c_(size) _SAL1_1_Source_(_Deref_post_z_bytecap_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post2_impl_(__zterm_impl,__bytecap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_bytecap_c_(size) _SAL1_1_Source_(_Deref_post_opt_z_bytecap_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post2_impl_(__zterm_impl,__bytecap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_cap_x_(size) _SAL1_1_Source_(_Deref_post_z_cap_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post2_impl_(__zterm_impl,__cap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_cap_x_(size) _SAL1_1_Source_(_Deref_post_opt_z_cap_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post2_impl_(__zterm_impl,__cap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_z_bytecap_x_(size) _SAL1_1_Source_(_Deref_post_z_bytecap_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post2_impl_(__zterm_impl,__bytecap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_z_bytecap_x_(size) _SAL1_1_Source_(_Deref_post_opt_z_bytecap_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post2_impl_(__zterm_impl,__bytecap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_cap_(size) _SAL1_1_Source_(_Deref_post_valid_cap_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__cap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_cap_(size) _SAL1_1_Source_(_Deref_post_opt_valid_cap_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__cap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_bytecap_(size) _SAL1_1_Source_(_Deref_post_valid_bytecap_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_bytecap_(size) _SAL1_1_Source_(_Deref_post_opt_valid_bytecap_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecap_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_cap_c_(size) _SAL1_1_Source_(_Deref_post_valid_cap_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__cap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_cap_c_(size) _SAL1_1_Source_(_Deref_post_opt_valid_cap_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__cap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_bytecap_c_(size) _SAL1_1_Source_(_Deref_post_valid_bytecap_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_bytecap_c_(size) _SAL1_1_Source_(_Deref_post_opt_valid_bytecap_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecap_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_cap_x_(size) _SAL1_1_Source_(_Deref_post_valid_cap_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__cap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_cap_x_(size) _SAL1_1_Source_(_Deref_post_opt_valid_cap_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__cap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_bytecap_x_(size) _SAL1_1_Source_(_Deref_post_valid_bytecap_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_bytecap_x_(size) _SAL1_1_Source_(_Deref_post_opt_valid_bytecap_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecap_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_count_(size) _SAL1_1_Source_(_Deref_post_count_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__count_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_count_(size) _SAL1_1_Source_(_Deref_post_opt_count_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__count_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_bytecount_(size) _SAL1_1_Source_(_Deref_post_bytecount_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecount_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_bytecount_(size) _SAL1_1_Source_(_Deref_post_opt_bytecount_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecount_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_count_c_(size) _SAL1_1_Source_(_Deref_post_count_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__count_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_count_c_(size) _SAL1_1_Source_(_Deref_post_opt_count_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__count_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_bytecount_c_(size) _SAL1_1_Source_(_Deref_post_bytecount_c_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecount_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_bytecount_c_(size) _SAL1_1_Source_(_Deref_post_opt_bytecount_c_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecount_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_count_x_(size) _SAL1_1_Source_(_Deref_post_count_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__count_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_count_x_(size) _SAL1_1_Source_(_Deref_post_opt_count_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__count_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_bytecount_x_(size) _SAL1_1_Source_(_Deref_post_bytecount_x_, (size), _Deref_post1_impl_(__notnull_impl_notref) _Deref_post1_impl_(__bytecount_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_bytecount_x_(size) _SAL1_1_Source_(_Deref_post_opt_bytecount_x_, (size), _Deref_post1_impl_(__maybenull_impl_notref) _Deref_post1_impl_(__bytecount_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_valid_ _SAL1_1_Source_(_Deref_post_valid_, (), _Deref_post1_impl_(__notnull_impl_notref) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_opt_valid_ _SAL1_1_Source_(_Deref_post_opt_valid_, (), _Deref_post1_impl_(__maybenull_impl_notref) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_notnull_ _SAL1_1_Source_(_Deref_post_notnull_, (), _Deref_post1_impl_(__notnull_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_maybenull_ _SAL1_1_Source_(_Deref_post_maybenull_, (), _Deref_post1_impl_(__maybenull_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_null_ _SAL1_1_Source_(_Deref_post_null_, (), _Deref_post1_impl_(__null_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_z_ _SAL1_1_Source_(_Deref_ret_z_, (), _Deref_ret1_impl_(__notnull_impl_notref) _Deref_ret1_impl_(__zterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_opt_z_ _SAL1_1_Source_(_Deref_ret_opt_z_, (), _Deref_ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__zterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_pre_readonly_ _SAL1_1_Source_(_Deref2_pre_readonly_, (), _Deref2_pre1_impl_(__readaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_valid_ _SAL1_1_Source_(_Ret_opt_valid_, (), _Ret1_impl_(__maybenull_impl_notref) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_z_ _SAL1_1_Source_(_Ret_opt_z_, (), _Ret2_impl_(__maybenull_impl,__zterm_impl) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_cap_(size) _SAL1_1_Source_(_Ret_cap_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_cap_(size) _SAL1_1_Source_(_Ret_opt_cap_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bytecap_(size) _SAL1_1_Source_(_Ret_bytecap_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_bytecap_(size) _SAL1_1_Source_(_Ret_opt_bytecap_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_cap_c_(size) _SAL1_1_Source_(_Ret_cap_c_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_cap_c_(size) _SAL1_1_Source_(_Ret_opt_cap_c_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bytecap_c_(size) _SAL1_1_Source_(_Ret_bytecap_c_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_bytecap_c_(size) _SAL1_1_Source_(_Ret_opt_bytecap_c_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_cap_x_(size) _SAL1_1_Source_(_Ret_cap_x_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_cap_x_(size) _SAL1_1_Source_(_Ret_opt_cap_x_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bytecap_x_(size) _SAL1_1_Source_(_Ret_bytecap_x_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_bytecap_x_(size) _SAL1_1_Source_(_Ret_opt_bytecap_x_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_z_cap_(size) _SAL1_1_Source_(_Ret_z_cap_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret2_impl_(__zterm_impl,__cap_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_z_cap_(size) _SAL1_1_Source_(_Ret_opt_z_cap_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret2_impl_(__zterm_impl,__cap_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_z_bytecap_(size) _SAL1_1_Source_(_Ret_z_bytecap_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret2_impl_(__zterm_impl,__bytecap_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_z_bytecap_(size) _SAL1_1_Source_(_Ret_opt_z_bytecap_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret2_impl_(__zterm_impl,__bytecap_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_count_(size) _SAL1_1_Source_(_Ret_count_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__count_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_count_(size) _SAL1_1_Source_(_Ret_opt_count_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__count_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bytecount_(size) _SAL1_1_Source_(_Ret_bytecount_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__bytecount_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_bytecount_(size) _SAL1_1_Source_(_Ret_opt_bytecount_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__bytecount_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_count_c_(size) _SAL1_1_Source_(_Ret_count_c_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__count_c_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_count_c_(size) _SAL1_1_Source_(_Ret_opt_count_c_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__count_c_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bytecount_c_(size) _SAL1_1_Source_(_Ret_bytecount_c_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__bytecount_c_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_bytecount_c_(size) _SAL1_1_Source_(_Ret_opt_bytecount_c_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__bytecount_c_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_count_x_(size) _SAL1_1_Source_(_Ret_count_x_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__count_x_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_count_x_(size) _SAL1_1_Source_(_Ret_opt_count_x_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__count_x_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bytecount_x_(size) _SAL1_1_Source_(_Ret_bytecount_x_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret1_impl_(__bytecount_x_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_bytecount_x_(size) _SAL1_1_Source_(_Ret_opt_bytecount_x_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret1_impl_(__bytecount_x_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_z_count_(size) _SAL1_1_Source_(_Ret_z_count_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret2_impl_(__zterm_impl,__count_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_z_count_(size) _SAL1_1_Source_(_Ret_opt_z_count_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret2_impl_(__zterm_impl,__count_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_z_bytecount_(size) _SAL1_1_Source_(_Ret_z_bytecount_, (size), _Ret1_impl_(__notnull_impl_notref) _Ret2_impl_(__zterm_impl,__bytecount_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_opt_z_bytecount_(size) _SAL1_1_Source_(_Ret_opt_z_bytecount_, (size), _Ret1_impl_(__maybenull_impl_notref) _Ret2_impl_(__zterm_impl,__bytecount_impl(size)) _Ret_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_ _SAL1_1_Source_(_Pre_opt_z_, (), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__zterm_impl) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_readonly_ _SAL1_1_Source_(_Pre_readonly_, (), _Pre1_impl_(__readaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_writeonly_ _SAL1_1_Source_(_Pre_writeonly_, (), _Pre1_impl_(__writeaccess_impl_notref))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_cap_(size) _SAL1_1_Source_(_Pre_cap_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_cap_(size) _SAL1_1_Source_(_Pre_opt_cap_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_bytecap_(size) _SAL1_1_Source_(_Pre_bytecap_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_bytecap_(size) _SAL1_1_Source_(_Pre_opt_bytecap_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_cap_c_(size) _SAL1_1_Source_(_Pre_cap_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_cap_c_(size) _SAL1_1_Source_(_Pre_opt_cap_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_bytecap_c_(size) _SAL1_1_Source_(_Pre_bytecap_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_bytecap_c_(size) _SAL1_1_Source_(_Pre_opt_bytecap_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecap_c_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_cap_c_one_ _SAL1_1_Source_(_Pre_cap_c_one_, (), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_c_one_notref_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_cap_c_one_ _SAL1_1_Source_(_Pre_opt_cap_c_one_, (), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_c_one_notref_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_cap_m_(mult,size) _SAL1_1_Source_(_Pre_cap_m_, (mult,size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__mult_impl(mult,size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_cap_m_(mult,size) _SAL1_1_Source_(_Pre_opt_cap_m_, (mult,size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__mult_impl(mult,size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_cap_for_(param) _SAL1_1_Source_(_Pre_cap_for_, (param), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_for_impl(param)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_cap_for_(param) _SAL1_1_Source_(_Pre_opt_cap_for_, (param), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_for_impl(param)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_cap_x_(size) _SAL1_1_Source_(_Pre_cap_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_cap_x_(size) _SAL1_1_Source_(_Pre_opt_cap_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_bytecap_x_(size) _SAL1_1_Source_(_Pre_bytecap_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_bytecap_x_(size) _SAL1_1_Source_(_Pre_opt_bytecap_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecap_x_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_ptrdiff_cap_(ptr) _SAL1_1_Source_(_Pre_ptrdiff_cap_, (ptr), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_x_impl(__ptrdiff(ptr))))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_ptrdiff_cap_(ptr) _SAL1_1_Source_(_Pre_opt_ptrdiff_cap_, (ptr), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_x_impl(__ptrdiff(ptr))))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_cap_(size) _SAL1_1_Source_(_Pre_z_cap_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre2_impl_(__zterm_impl,__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_cap_(size) _SAL1_1_Source_(_Pre_opt_z_cap_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre2_impl_(__zterm_impl,__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_bytecap_(size) _SAL1_1_Source_(_Pre_z_bytecap_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre2_impl_(__zterm_impl,__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_bytecap_(size) _SAL1_1_Source_(_Pre_opt_z_bytecap_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre2_impl_(__zterm_impl,__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_cap_c_(size) _SAL1_1_Source_(_Pre_z_cap_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre2_impl_(__zterm_impl,__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_cap_c_(size) _SAL1_1_Source_(_Pre_opt_z_cap_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre2_impl_(__zterm_impl,__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_bytecap_c_(size) _SAL1_1_Source_(_Pre_z_bytecap_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre2_impl_(__zterm_impl,__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_bytecap_c_(size) _SAL1_1_Source_(_Pre_opt_z_bytecap_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre2_impl_(__zterm_impl,__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_cap_x_(size) _SAL1_1_Source_(_Pre_z_cap_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre2_impl_(__zterm_impl,__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_cap_x_(size) _SAL1_1_Source_(_Pre_opt_z_cap_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre2_impl_(__zterm_impl,__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_z_bytecap_x_(size) _SAL1_1_Source_(_Pre_z_bytecap_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre2_impl_(__zterm_impl,__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_z_bytecap_x_(size) _SAL1_1_Source_(_Pre_opt_z_bytecap_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre2_impl_(__zterm_impl,__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_cap_(size) _SAL1_1_Source_(_Pre_valid_cap_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_cap_(size) _SAL1_1_Source_(_Pre_opt_valid_cap_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_bytecap_(size) _SAL1_1_Source_(_Pre_valid_bytecap_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_bytecap_(size) _SAL1_1_Source_(_Pre_opt_valid_bytecap_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecap_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_cap_c_(size) _SAL1_1_Source_(_Pre_valid_cap_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_cap_c_(size) _SAL1_1_Source_(_Pre_opt_valid_cap_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_bytecap_c_(size) _SAL1_1_Source_(_Pre_valid_bytecap_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_bytecap_c_(size) _SAL1_1_Source_(_Pre_opt_valid_bytecap_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecap_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_cap_x_(size) _SAL1_1_Source_(_Pre_valid_cap_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_cap_x_(size) _SAL1_1_Source_(_Pre_opt_valid_cap_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_bytecap_x_(size) _SAL1_1_Source_(_Pre_valid_bytecap_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_valid_bytecap_x_(size) _SAL1_1_Source_(_Pre_opt_valid_bytecap_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecap_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_count_(size) _SAL1_1_Source_(_Pre_count_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__count_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_count_(size) _SAL1_1_Source_(_Pre_opt_count_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__count_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_bytecount_(size) _SAL1_1_Source_(_Pre_bytecount_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecount_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_bytecount_(size) _SAL1_1_Source_(_Pre_opt_bytecount_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecount_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_count_c_(size) _SAL1_1_Source_(_Pre_count_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__count_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_count_c_(size) _SAL1_1_Source_(_Pre_opt_count_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__count_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_bytecount_c_(size) _SAL1_1_Source_(_Pre_bytecount_c_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecount_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_bytecount_c_(size) _SAL1_1_Source_(_Pre_opt_bytecount_c_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecount_c_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_count_x_(size) _SAL1_1_Source_(_Pre_count_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__count_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_count_x_(size) _SAL1_1_Source_(_Pre_opt_count_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__count_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_bytecount_x_(size) _SAL1_1_Source_(_Pre_bytecount_x_, (size), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__bytecount_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_bytecount_x_(size) _SAL1_1_Source_(_Pre_opt_bytecount_x_, (size), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__bytecount_x_impl(size)) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_ptrdiff_count_(ptr) _SAL1_1_Source_(_Pre_ptrdiff_count_, (ptr), _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__count_x_impl(__ptrdiff(ptr))) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_opt_ptrdiff_count_(ptr) _SAL1_1_Source_(_Pre_opt_ptrdiff_count_, (ptr), _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__count_x_impl(__ptrdiff(ptr))) _Pre_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_maybez_ _SAL_L_Source_(_Post_maybez_, (), _Post1_impl_(__maybezterm_impl))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_cap_(size) _SAL1_1_Source_(_Post_cap_, (size), _Post1_impl_(__cap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_bytecap_(size) _SAL1_1_Source_(_Post_bytecap_, (size), _Post1_impl_(__bytecap_impl(size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_count_(size) _SAL1_1_Source_(_Post_count_, (size), _Post1_impl_(__count_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_bytecount_(size) _SAL1_1_Source_(_Post_bytecount_, (size), _Post1_impl_(__bytecount_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_count_c_(size) _SAL1_1_Source_(_Post_count_c_, (size), _Post1_impl_(__count_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_bytecount_c_(size) _SAL1_1_Source_(_Post_bytecount_c_, (size), _Post1_impl_(__bytecount_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_count_x_(size) _SAL1_1_Source_(_Post_count_x_, (size), _Post1_impl_(__count_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_bytecount_x_(size) _SAL1_1_Source_(_Post_bytecount_x_, (size), _Post1_impl_(__bytecount_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_count_(size) _SAL1_1_Source_(_Post_z_count_, (size), _Post2_impl_(__zterm_impl,__count_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_bytecount_(size) _SAL1_1_Source_(_Post_z_bytecount_, (size), _Post2_impl_(__zterm_impl,__bytecount_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_count_c_(size) _SAL1_1_Source_(_Post_z_count_c_, (size), _Post2_impl_(__zterm_impl,__count_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_bytecount_c_(size) _SAL1_1_Source_(_Post_z_bytecount_c_, (size), _Post2_impl_(__zterm_impl,__bytecount_c_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_count_x_(size) _SAL1_1_Source_(_Post_z_count_x_, (size), _Post2_impl_(__zterm_impl,__count_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_z_bytecount_x_(size) _SAL1_1_Source_(_Post_z_bytecount_x_, (size), _Post2_impl_(__zterm_impl,__bytecount_x_impl(size)) _Post_valid_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_z_ _SAL1_1_Source_(_Prepost_opt_z_, (), _Pre_opt_z_ _Post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_count_(size) _SAL1_1_Source_(_Prepost_count_, (size), _Pre_count_(size) _Post_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_count_(size) _SAL1_1_Source_(_Prepost_opt_count_, (size), _Pre_opt_count_(size) _Post_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_bytecount_(size) _SAL1_1_Source_(_Prepost_bytecount_, (size), _Pre_bytecount_(size) _Post_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_bytecount_(size) _SAL1_1_Source_(_Prepost_opt_bytecount_, (size), _Pre_opt_bytecount_(size) _Post_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_count_c_(size) _SAL1_1_Source_(_Prepost_count_c_, (size), _Pre_count_c_(size) _Post_count_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_count_c_(size) _SAL1_1_Source_(_Prepost_opt_count_c_, (size), _Pre_opt_count_c_(size) _Post_count_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_bytecount_c_(size) _SAL1_1_Source_(_Prepost_bytecount_c_, (size), _Pre_bytecount_c_(size) _Post_bytecount_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_bytecount_c_(size) _SAL1_1_Source_(_Prepost_opt_bytecount_c_, (size), _Pre_opt_bytecount_c_(size) _Post_bytecount_c_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_count_x_(size) _SAL1_1_Source_(_Prepost_count_x_, (size), _Pre_count_x_(size) _Post_count_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_count_x_(size) _SAL1_1_Source_(_Prepost_opt_count_x_, (size), _Pre_opt_count_x_(size) _Post_count_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_bytecount_x_(size) _SAL1_1_Source_(_Prepost_bytecount_x_, (size), _Pre_bytecount_x_(size) _Post_bytecount_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_bytecount_x_(size) _SAL1_1_Source_(_Prepost_opt_bytecount_x_, (size), _Pre_opt_bytecount_x_(size) _Post_bytecount_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_valid_ _SAL1_1_Source_(_Prepost_valid_, (), _Pre_valid_ _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Prepost_opt_valid_ _SAL1_1_Source_(_Prepost_opt_valid_, (), _Pre_opt_valid_ _Post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_z_ _SAL1_1_Source_(_Deref_prepost_z_, (), _Deref_pre_z_ _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_z_ _SAL1_1_Source_(_Deref_prepost_opt_z_, (), _Deref_pre_opt_z_ _Deref_post_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_cap_(size) _SAL1_1_Source_(_Deref_prepost_cap_, (size), _Deref_pre_cap_(size) _Deref_post_cap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_cap_(size) _SAL1_1_Source_(_Deref_prepost_opt_cap_, (size), _Deref_pre_opt_cap_(size) _Deref_post_opt_cap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_bytecap_(size) _SAL1_1_Source_(_Deref_prepost_bytecap_, (size), _Deref_pre_bytecap_(size) _Deref_post_bytecap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_bytecap_(size) _SAL1_1_Source_(_Deref_prepost_opt_bytecap_, (size), _Deref_pre_opt_bytecap_(size) _Deref_post_opt_bytecap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_cap_x_(size) _SAL1_1_Source_(_Deref_prepost_cap_x_, (size), _Deref_pre_cap_x_(size) _Deref_post_cap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_cap_x_(size) _SAL1_1_Source_(_Deref_prepost_opt_cap_x_, (size), _Deref_pre_opt_cap_x_(size) _Deref_post_opt_cap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_bytecap_x_(size) _SAL1_1_Source_(_Deref_prepost_bytecap_x_, (size), _Deref_pre_bytecap_x_(size) _Deref_post_bytecap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_bytecap_x_(size) _SAL1_1_Source_(_Deref_prepost_opt_bytecap_x_, (size), _Deref_pre_opt_bytecap_x_(size) _Deref_post_opt_bytecap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_z_cap_(size) _SAL1_1_Source_(_Deref_prepost_z_cap_, (size), _Deref_pre_z_cap_(size) _Deref_post_z_cap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_z_cap_(size) _SAL1_1_Source_(_Deref_prepost_opt_z_cap_, (size), _Deref_pre_opt_z_cap_(size) _Deref_post_opt_z_cap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_z_bytecap_(size) _SAL1_1_Source_(_Deref_prepost_z_bytecap_, (size), _Deref_pre_z_bytecap_(size) _Deref_post_z_bytecap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_z_bytecap_(size) _SAL1_1_Source_(_Deref_prepost_opt_z_bytecap_, (size), _Deref_pre_opt_z_bytecap_(size) _Deref_post_opt_z_bytecap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_valid_cap_(size) _SAL1_1_Source_(_Deref_prepost_valid_cap_, (size), _Deref_pre_valid_cap_(size) _Deref_post_valid_cap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_valid_cap_(size) _SAL1_1_Source_(_Deref_prepost_opt_valid_cap_, (size), _Deref_pre_opt_valid_cap_(size) _Deref_post_opt_valid_cap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_valid_bytecap_(size) _SAL1_1_Source_(_Deref_prepost_valid_bytecap_, (size), _Deref_pre_valid_bytecap_(size) _Deref_post_valid_bytecap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_valid_bytecap_(size) _SAL1_1_Source_(_Deref_prepost_opt_valid_bytecap_, (size), _Deref_pre_opt_valid_bytecap_(size) _Deref_post_opt_valid_bytecap_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_valid_cap_x_(size) _SAL1_1_Source_(_Deref_prepost_valid_cap_x_, (size), _Deref_pre_valid_cap_x_(size) _Deref_post_valid_cap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_valid_cap_x_(size) _SAL1_1_Source_(_Deref_prepost_opt_valid_cap_x_, (size), _Deref_pre_opt_valid_cap_x_(size) _Deref_post_opt_valid_cap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_valid_bytecap_x_(size) _SAL1_1_Source_(_Deref_prepost_valid_bytecap_x_, (size), _Deref_pre_valid_bytecap_x_(size) _Deref_post_valid_bytecap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_valid_bytecap_x_(size) _SAL1_1_Source_(_Deref_prepost_opt_valid_bytecap_x_, (size), _Deref_pre_opt_valid_bytecap_x_(size) _Deref_post_opt_valid_bytecap_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_count_(size) _SAL1_1_Source_(_Deref_prepost_count_, (size), _Deref_pre_count_(size) _Deref_post_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_count_(size) _SAL1_1_Source_(_Deref_prepost_opt_count_, (size), _Deref_pre_opt_count_(size) _Deref_post_opt_count_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_bytecount_(size) _SAL1_1_Source_(_Deref_prepost_bytecount_, (size), _Deref_pre_bytecount_(size) _Deref_post_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_bytecount_(size) _SAL1_1_Source_(_Deref_prepost_opt_bytecount_, (size), _Deref_pre_opt_bytecount_(size) _Deref_post_opt_bytecount_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_count_x_(size) _SAL1_1_Source_(_Deref_prepost_count_x_, (size), _Deref_pre_count_x_(size) _Deref_post_count_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_count_x_(size) _SAL1_1_Source_(_Deref_prepost_opt_count_x_, (size), _Deref_pre_opt_count_x_(size) _Deref_post_opt_count_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_bytecount_x_(size) _SAL1_1_Source_(_Deref_prepost_bytecount_x_, (size), _Deref_pre_bytecount_x_(size) _Deref_post_bytecount_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_bytecount_x_(size) _SAL1_1_Source_(_Deref_prepost_opt_bytecount_x_, (size), _Deref_pre_opt_bytecount_x_(size) _Deref_post_opt_bytecount_x_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_valid_ _SAL1_1_Source_(_Deref_prepost_valid_, (), _Deref_pre_valid_ _Deref_post_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_prepost_opt_valid_ _SAL1_1_Source_(_Deref_prepost_opt_valid_, (), _Deref_pre_opt_valid_ _Deref_post_opt_valid_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_z_cap_c_(size) _SAL1_1_Source_(_Deref_out_z_cap_c_, (size), _Deref_pre_cap_c_(size) _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_inout_z_cap_c_(size) _SAL1_1_Source_(_Deref_inout_z_cap_c_, (size), _Deref_pre_z_cap_c_(size) _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_z_bytecap_c_(size) _SAL1_1_Source_(_Deref_out_z_bytecap_c_, (size), _Deref_pre_bytecap_c_(size) _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_inout_z_bytecap_c_(size) _SAL1_1_Source_(_Deref_inout_z_bytecap_c_, (size), _Deref_pre_z_bytecap_c_(size) _Deref_post_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_inout_z_ _SAL1_1_Source_(_Deref_inout_z_, (), _Deref_prepost_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Always_impl_(annos) _Group_(annos _SAL_nop_impl_) _On_failure_impl_(annos _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Bound_impl_ _SA_annotes0(SAL_bound)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_range_impl_(min,max) _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Literal_impl_ _SA_annotes1(SAL_constant, __yes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybenull_impl_ _SA_annotes1(SAL_null, __maybe)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybevalid_impl_ _SA_annotes1(SAL_valid, __maybe)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Must_inspect_impl_ _Post_impl_ _SA_annotes0(SAL_mustInspect)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notliteral_impl_ _SA_annotes1(SAL_constant, __no)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notnull_impl_ _SA_annotes1(SAL_null, __no)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notvalid_impl_ _SA_annotes1(SAL_valid, __no)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _NullNull_terminated_impl_ _Group_(_SA_annotes1(SAL_nullTerminated, __yes) _SA_annotes1(SAL_readableTo,inexpressibleCount("NullNull terminated string")))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Null_impl_ _SA_annotes1(SAL_null, __yes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Null_terminated_impl_ _SA_annotes1(SAL_nullTerminated, __yes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_impl_ _Pre1_impl_(__notnull_impl_notref) _Pre1_impl_(__cap_c_one_notref_impl) _Post_valid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_opt_impl_ _Pre1_impl_(__maybenull_impl_notref) _Pre1_impl_(__cap_c_one_notref_impl) _Post_valid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Points_to_data_impl_ _At_(*_Curr_, _SA_annotes1(SAL_mayBePointer, __no))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_satisfies_impl_(cond) _Post_impl_ _Satisfies_impl_(cond)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_valid_impl_ _Post1_impl_(__valid_impl)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_satisfies_impl_(cond) _Pre_impl_ _Satisfies_impl_(cond)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_impl_ _Pre1_impl_(__valid_impl)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Range_impl_(min,max) _SA_annotes2(SAL_range, min, max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_bytes_impl_(size) _SA_annotes1(SAL_readableTo, byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_elements_impl_(size) _SA_annotes1(SAL_readableTo, elementCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_valid_impl_ _Ret1_impl_(__valid_impl)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Satisfies_impl_(cond) _SA_annotes1(SAL_satisfies, cond)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Valid_impl_ _SA_annotes1(SAL_valid, __yes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_bytes_impl_(size) _SA_annotes1(SAL_writableTo, byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_elements_impl_(size) _SA_annotes1(SAL_writableTo, elementCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_range_impl_(min,max) _Pre_impl_ _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_range_impl_(min,max) _Post_impl_ _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_range_impl_(min,max) _Post_impl_ _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_range_impl_(min,max) _Deref_pre_impl_ _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_range_impl_(min,max) _Deref_post_impl_ _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_range_impl_(min,max) _Deref_post_impl_ _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre_impl_ _Pre_impl_ _Notref_impl_ _Deref_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post_impl_ _Post_impl_ _Notref_impl_ _Deref_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __AuToQuOtE _SA_annotes0(SAL_AuToQuOtE)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deferTypecheck _SA_annotes0(SAL_deferTypecheck)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_SPECSTRIZE( x ) #x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __nop_impl(x) x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes0(n) [SAL_annotes(Name=#n)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes1(n,pp1) [SAL_annotes(Name=#n, p1=_SA_SPECSTRIZE(pp1))]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes2(n,pp1,pp2) [SAL_annotes(Name=#n, p1=_SA_SPECSTRIZE(pp1), p2=_SA_SPECSTRIZE(pp2))]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes3(n,pp1,pp2,pp3) [SAL_annotes(Name=#n, p1=_SA_SPECSTRIZE(pp1), p2=_SA_SPECSTRIZE(pp2), p3=_SA_SPECSTRIZE(pp3))]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_impl_ [SAL_pre]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_impl_ [SAL_post]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_impl_ [SAL_deref]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notref_impl_ [SAL_notref]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __ANNOTATION(fun) _SA_annotes0(SAL_annotation) void __SA_##fun;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __PRIMOP(type, fun) _SA_annotes0(SAL_primop) type __SA_##fun;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __QUALIFIER(fun) _SA_annotes0(SAL_qualifier) void __SA_##fun;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __In_impl_ [SA_Pre(Valid=SA_Yes)] [SA_Pre(Deref=1, Notref=1, Access=SA_Read)] __declspec("SAL_pre SAL_valid")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes0(n) __declspec(#n)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes1(n,pp1) __declspec(#n "(" _SA_SPECSTRIZE(pp1) ")" )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes2(n,pp1,pp2) __declspec(#n "(" _SA_SPECSTRIZE(pp1) "," _SA_SPECSTRIZE(pp2) ")")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes3(n,pp1,pp2,pp3) __declspec(#n "(" _SA_SPECSTRIZE(pp1) "," _SA_SPECSTRIZE(pp2) "," _SA_SPECSTRIZE(pp3) ")")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_impl_ _SA_annotes0(SAL_pre)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_impl_ _SA_annotes0(SAL_post)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_impl_ _SA_annotes0(SAL_deref)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notref_impl_ _SA_annotes0(SAL_notref)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __ANNOTATION(fun) _SA_annotes0(SAL_annotation) void __SA_##fun
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __PRIMOP(type, fun) _SA_annotes0(SAL_primop) type __SA_##fun
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __QUALIFIER(fun) _SA_annotes0(SAL_qualifier) void __SA_##fun;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __In_impl_ _Pre_impl_ _SA_annotes0(SAL_valid) _Pre_impl_ _Deref_impl_ _Notref_impl_ _SA_annotes0(SAL_readonly)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes0(n)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes1(n,pp1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes2(n,pp1,pp2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_annotes3(n,pp1,pp2,pp3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __ANNOTATION(fun)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __PRIMOP(type, fun)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __QUALIFIER(type, fun)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Check_return_impl_ [SA_Post(MustCheck=SA_Yes)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Success_impl_(expr) [SA_Success(Condition=#expr)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _On_failure_impl_(annos) [SAL_context(p1="SAL_failed")] _Group_(_Post_impl_ _Group_(annos _SAL_nop_impl_))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Printf_format_string_impl_ [SA_FormatString(Style="printf")]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_format_string_impl_ [SA_FormatString(Style="scanf")]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_s_format_string_impl_ [SA_FormatString(Style="scanf_s")]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bound_impl_ [SA_PreBound(Deref=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bound_impl_ [SA_PostBound(Deref=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bound_impl_ [SA_PostBound(Deref=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_bound_impl_ [SA_PreBound(Deref=1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_bound_impl_ [SA_PostBound(Deref=1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_bound_impl_ [SA_PostBound(Deref=1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __valid_impl Valid=SA_Yes
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybevalid_impl Valid=SA_Maybe
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notvalid_impl Valid=SA_No
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __null_impl Null=SA_Yes
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybenull_impl Null=SA_Maybe
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notnull_impl Null=SA_No
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __null_impl_notref Null=SA_Yes,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybenull_impl_notref Null=SA_Maybe,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notnull_impl_notref Null=SA_No,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __zterm_impl NullTerminated=SA_Yes
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybezterm_impl NullTerminated=SA_Maybe
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybzterm_impl NullTerminated=SA_Maybe
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notzterm_impl NullTerminated=SA_No
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readaccess_impl Access=SA_Read
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __writeaccess_impl Access=SA_Write
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __allaccess_impl Access=SA_ReadWrite
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readaccess_impl_notref Access=SA_Read,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __writeaccess_impl_notref Access=SA_Write,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __allaccess_impl_notref Access=SA_ReadWrite,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_impl(size) WritableElements="\n"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_impl(size) WritableBytes="\n"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_impl(size) ValidBytes="\n"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_impl(size) ValidElements="\n"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_impl(size) WritableElements=#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_impl(size) WritableBytes=#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_impl(size) ValidBytes=#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_impl(size) ValidElements=#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_c_impl(size) WritableElementsConst=size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_c_one_notref_impl WritableElementsConst=1,Notref=1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_for_impl(param) WritableElementsLength=#param
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_x_impl(size) WritableElements="\n@"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_c_impl(size) WritableBytesConst=size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_x_impl(size) WritableBytes="\n@"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __mult_impl(mult,size) __cap_impl((mult)*(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_c_impl(size) ValidElementsConst=size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_x_impl(size) ValidElements="\n@"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_c_impl(size) ValidBytesConst=size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_x_impl(size) ValidBytes="\n@"#size
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_impl_(target, annos) [SAL_at(p1=#target)] _Group_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_buffer_impl_(target, iter, bound, annos) [SAL_at_buffer(p1=#target, p2=#iter, p3=#bound)] _Group_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _When_impl_(expr, annos) [SAL_when(p1=#expr)] _Group_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Group_impl_(annos) [SAL_begin] annos [SAL_end]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _GrouP_impl_(annos) [SAL_BEGIN] annos [SAL_END]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Use_decl_anno_impl_ _SA_annotes0(SAL_useHeader)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre1_impl_(p1) [SA_Pre(p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre2_impl_(p1,p2) [SA_Pre(p1,p2)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre3_impl_(p1,p2,p3) [SA_Pre(p1,p2,p3)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post1_impl_(p1) [SA_Post(p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post2_impl_(p1,p2) [SA_Post(p1,p2)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post3_impl_(p1,p2,p3) [SA_Post(p1,p2,p3)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret1_impl_(p1) [SA_Post(p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret2_impl_(p1,p2) [SA_Post(p1,p2)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret3_impl_(p1,p2,p3) [SA_Post(p1,p2,p3)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre1_impl_(p1) [SA_Pre(Deref=1,p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre2_impl_(p1,p2) [SA_Pre(Deref=1,p1,p2)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre3_impl_(p1,p2,p3) [SA_Pre(Deref=1,p1,p2,p3)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post1_impl_(p1) [SA_Post(Deref=1,p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post2_impl_(p1,p2) [SA_Post(Deref=1,p1,p2)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post3_impl_(p1,p2,p3) [SA_Post(Deref=1,p1,p2,p3)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret1_impl_(p1) [SA_Post(Deref=1,p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret2_impl_(p1,p2) [SA_Post(Deref=1,p1,p2)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret3_impl_(p1,p2,p3) [SA_Post(Deref=1,p1,p2,p3)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_pre1_impl_(p1) [SA_Pre(Deref=2,Notref=1,p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_post1_impl_(p1) [SA_Post(Deref=2,Notref=1,p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_ret1_impl_(p1) [SA_Post(Deref=2,Notref=1,p1)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_typefix(ctype) [SAL_typefix(p1=_SA_SPECSTRIZE(ctype))]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_exceptthat [SAL_except]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Check_return_impl_ __post _SA_annotes0(SAL_checkReturn)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Success_impl_(expr) _SA_annotes1(SAL_success, expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _On_failure_impl_(annos) _SA_annotes1(SAL_context, SAL_failed) _Group_(_Post_impl_ _Group_(_SAL_nop_impl_ annos))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Printf_format_string_impl_ _SA_annotes1(SAL_IsFormatString, "printf")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_format_string_impl_ _SA_annotes1(SAL_IsFormatString, "scanf")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_s_format_string_impl_ _SA_annotes1(SAL_IsFormatString, "scanf_s")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bound_impl_ _Pre_impl_ _Bound_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bound_impl_ _Post_impl_ _Bound_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bound_impl_ _Post_impl_ _Bound_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_bound_impl_ _Deref_pre_impl_ _Bound_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_bound_impl_ _Deref_post_impl_ _Bound_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_bound_impl_ _Deref_post_impl_ _Bound_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __null_impl _SA_annotes0(SAL_null)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notnull_impl _SA_annotes0(SAL_notnull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybenull_impl _SA_annotes0(SAL_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __valid_impl _SA_annotes0(SAL_valid)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notvalid_impl _SA_annotes0(SAL_notvalid)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybevalid_impl _SA_annotes0(SAL_maybevalid)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __null_impl_notref _Notref_ _Null_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybenull_impl_notref _Notref_ _Maybenull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notnull_impl_notref _Notref_ _Notnull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __zterm_impl _SA_annotes1(SAL_nullTerminated, __yes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybezterm_impl _SA_annotes1(SAL_nullTerminated, __maybe)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybzterm_impl _SA_annotes1(SAL_nullTerminated, __maybe)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notzterm_impl _SA_annotes1(SAL_nullTerminated, __no)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readaccess_impl _SA_annotes1(SAL_access, 0x1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __writeaccess_impl _SA_annotes1(SAL_access, 0x2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __allaccess_impl _SA_annotes1(SAL_access, 0x3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readaccess_impl_notref _Notref_ _SA_annotes1(SAL_access, 0x1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __writeaccess_impl_notref _Notref_ _SA_annotes1(SAL_access, 0x2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __allaccess_impl_notref _Notref_ _SA_annotes1(SAL_access, 0x3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_impl(size) _SA_annotes1(SAL_writableTo,elementCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_c_impl(size) _SA_annotes1(SAL_writableTo,elementCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_c_one_notref_impl _Notref_ _SA_annotes1(SAL_writableTo,elementCount(1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_for_impl(param) _SA_annotes1(SAL_writableTo,inexpressibleCount(sizeof(param)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cap_x_impl(size) _SA_annotes1(SAL_writableTo,inexpressibleCount(#size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_impl(size) _SA_annotes1(SAL_writableTo,byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_c_impl(size) _SA_annotes1(SAL_writableTo,byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecap_x_impl(size) _SA_annotes1(SAL_writableTo,inexpressibleCount(#size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __mult_impl(mult,size) _SA_annotes1(SAL_writableTo,(mult)*(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_impl(size) _SA_annotes1(SAL_readableTo,elementCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_c_impl(size) _SA_annotes1(SAL_readableTo,elementCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __count_x_impl(size) _SA_annotes1(SAL_readableTo,inexpressibleCount(#size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_impl(size) _SA_annotes1(SAL_readableTo,byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_c_impl(size) _SA_annotes1(SAL_readableTo,byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bytecount_x_impl(size) _SA_annotes1(SAL_readableTo,inexpressibleCount(#size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_impl_(target, annos) _SA_annotes0(SAL_at(target)) _Group_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_buffer_impl_(target, iter, bound, annos) _SA_annotes3(SAL_at_buffer, target, iter, bound) _Group_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Group_impl_(annos) _SA_annotes0(SAL_begin) annos _SA_annotes0(SAL_end)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _GrouP_impl_(annos) _SA_annotes0(SAL_BEGIN) annos _SA_annotes0(SAL_END)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _When_impl_(expr, annos) _SA_annotes0(SAL_when(expr)) _Group_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Use_decl_anno_impl_ __declspec("SAL_useHeader()")
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre1_impl_(p1) _Pre_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre2_impl_(p1,p2) _Pre_impl_ p1 _Pre_impl_ p2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre3_impl_(p1,p2,p3) _Pre_impl_ p1 _Pre_impl_ p2 _Pre_impl_ p3
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post1_impl_(p1) _Post_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post2_impl_(p1,p2) _Post_impl_ p1 _Post_impl_ p2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post3_impl_(p1,p2,p3) _Post_impl_ p1 _Post_impl_ p2 _Post_impl_ p3
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret1_impl_(p1) _Post_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret2_impl_(p1,p2) _Post_impl_ p1 _Post_impl_ p2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret3_impl_(p1,p2,p3) _Post_impl_ p1 _Post_impl_ p2 _Post_impl_ p3
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre1_impl_(p1) _Deref_pre_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre2_impl_(p1,p2) _Deref_pre_impl_ p1 _Deref_pre_impl_ p2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre3_impl_(p1,p2,p3) _Deref_pre_impl_ p1 _Deref_pre_impl_ p2 _Deref_pre_impl_ p3
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post1_impl_(p1) _Deref_post_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post2_impl_(p1,p2) _Deref_post_impl_ p1 _Deref_post_impl_ p2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post3_impl_(p1,p2,p3) _Deref_post_impl_ p1 _Deref_post_impl_ p2 _Deref_post_impl_ p3
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret1_impl_(p1) _Deref_post_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret2_impl_(p1,p2) _Deref_post_impl_ p1 _Deref_post_impl_ p2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret3_impl_(p1,p2,p3) _Deref_post_impl_ p1 _Deref_post_impl_ p2 _Deref_post_impl_ p3
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_pre1_impl_(p1) _Deref_pre_impl_ _Notref_impl_ _Deref_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_post1_impl_(p1) _Deref_post_impl_ _Notref_impl_ _Deref_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_ret1_impl_(p1) _Deref_post_impl_ _Notref_impl_ _Deref_impl_ p1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_typefix(ctype) _SA_annotes1(SAL_typefix, ctype)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_exceptthat _SA_annotes0(SAL_except)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SA( id ) id
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define REPEATABLE [repeatable]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SA( id ) SA_##id
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_impl_(target, annos) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_buffer_impl_(target, iter, bound, annos) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _When_impl_(expr, annos) annos
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Group_impl_(annos) annos
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _GrouP_impl_(annos) annos
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Use_decl_anno_impl_ [__M_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Points_to_data_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Literal_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notliteral_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_valid_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_valid_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_valid_impl_ [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Check_return_impl_ [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Must_inspect_impl_ [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Success_impl_(expr) [__M_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _On_failure_impl_(expr) [__M_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Always_impl_(expr) [__M_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Printf_format_string_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_format_string_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Scanf_s_format_string_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Raises_SEH_exception_impl_ [__M_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybe_raises_SEH_exception_impl_ [__M_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_bound_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_bound_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_bound_impl_ [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_bound_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_bound_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_bound_impl_ [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Range_impl_(min,max) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_range_impl_(min,max) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_range_impl_(min,max) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_range_impl_(min,max) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_range_impl_(min,max) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_range_impl_(min,max) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_range_impl_(min,max) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_range_impl_(min,max) [__F_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_satisfies_impl_(cond) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_satisfies_impl_(cond) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Satisfies_impl_(cond) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Null_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notnull_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybenull_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Valid_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Notvalid_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Maybevalid_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_bytes_impl_(size) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_elements_impl_(size) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_bytes_impl_(size) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_elements_impl_(size) [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Null_terminated_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _NullNull_terminated_impl_ [__A_(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre1_impl_(p1) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre2_impl_(p1,p2) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre3_impl_(p1,p2,p3) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_impl_ [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post1_impl_(p1) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post2_impl_(p1,p2) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post3_impl_(p1,p2,p3) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret1_impl_(p1) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret2_impl_(p1,p2) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret3_impl_(p1,p2,p3) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre1_impl_(p1) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre2_impl_(p1,p2) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre3_impl_(p1,p2,p3) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post1_impl_(p1) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post2_impl_(p1,p2) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post3_impl_(p1,p2,p3) [__P_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret1_impl_(p1) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret2_impl_(p1,p2) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret3_impl_(p1,p2,p3) [__R_impl(__d_=0)]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_pre1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_post1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_ret1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SAL_nop_impl_ X
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_impl_(target, annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _When_impl_(expr, annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Group_impl_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _GrouP_impl_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _At_buffer_impl_(target, iter, bound, annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Success_impl_(expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _On_failure_impl_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Always_impl_(annos)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _In_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Out_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_in_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_out_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Satisfies_impl_(expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre_satisfies_impl_(expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post_satisfies_impl_(expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Field_range_impl_(min,max)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre2_impl_(p1,p2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Pre3_impl_(p1,p2,p3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post2_impl_(p1,p2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Post3_impl_(p1,p2,p3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret2_impl_(p1,p2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Ret3_impl_(p1,p2,p3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre2_impl_(p1,p2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_pre3_impl_(p1,p2,p3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post2_impl_(p1,p2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_post3_impl_(p1,p2,p3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret2_impl_(p1,p2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref_ret3_impl_(p1,p2,p3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_pre1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_post1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Deref2_ret1_impl_(p1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_bytes_impl_(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Readable_elements_impl_(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_bytes_impl_(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _Writable_elements_impl_(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_typefix(ctype)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __nothrow __declspec(nothrow)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _SA_SPECSTRIZE( x ) #x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __null _Null_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notnull _Notnull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybenull _Maybenull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readonly _Pre1_impl_(__readaccess_impl)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notreadonly _Pre1_impl_(__allaccess_impl)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybereadonly _Pre1_impl_(__readaccess_impl)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __valid _Valid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __notvalid _Notvalid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __maybevalid _Maybevalid_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readableTo(extent) _SA_annotes1(SAL_readableTo, extent)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __elem_readableTo(size) _SA_annotes1(SAL_readableTo, elementCount( size ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __byte_readableTo(size) _SA_annotes1(SAL_readableTo, byteCount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __writableTo(size) _SA_annotes1(SAL_writableTo, size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __elem_writableTo(size) _SA_annotes1(SAL_writableTo, elementCount( size ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __byte_writableTo(size) _SA_annotes1(SAL_writableTo, byteCount( size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref _Deref_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __pre _Pre_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __post _Post_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __precond(expr) __pre
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __postcond(expr) __post
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __exceptthat __inner_exceptthat
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __refparam _Notref_ __deref __notreadonly
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_control_entrypoint(category) _SA_annotes2(SAL_entrypoint, controlEntry, #category)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_data_entrypoint(category) _SA_annotes2(SAL_entrypoint, dataEntry, #category)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_override _SA_annotes0(__override)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_callback _SA_annotes0(__callback)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_blocksOn(resource) _SA_annotes1(SAL_blocksOn, resource)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_fallthrough_dec __inline __nothrow void __FallThrough() {}
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_fallthrough __FallThrough();
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __post_except_maybenull __post __inner_exceptthat _Maybenull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __pre_except_maybenull __pre __inner_exceptthat _Maybenull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __post_deref_except_maybenull __post __deref __inner_exceptthat _Maybenull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __pre_deref_except_maybenull __pre __deref __inner_exceptthat _Maybenull_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inexpressible_readableTo(size) _Readable_elements_impl_(_Inexpressible_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inexpressible_writableTo(size) _Writable_elements_impl_(_Inexpressible_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __readableTo(extent)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __elem_readableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __byte_readableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __writableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __elem_writableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __byte_writableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __precond(expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __postcond(expr)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_blocksOn(resource)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_control_entrypoint(category)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inner_data_entrypoint(category)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inexpressible_readableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inexpressible_writableTo(size)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __ecount(size) _SAL1_Source_(__ecount, (size), __notnull __elem_writableTo(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bcount(size) _SAL1_Source_(__bcount, (size), __notnull __byte_writableTo(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in _SAL1_Source_(__in, (), _In_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_ecount(size) _SAL1_Source_(__in_ecount, (size), _In_reads_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_bcount(size) _SAL1_Source_(__in_bcount, (size), _In_reads_bytes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_z _SAL1_Source_(__in_z, (), _In_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_ecount_z(size) _SAL1_Source_(__in_ecount_z, (size), _In_reads_z_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_bcount_z(size) _SAL1_Source_(__in_bcount_z, (size), __in_bcount(size) __pre __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_nz _SAL1_Source_(__in_nz, (), __in)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_ecount_nz(size) _SAL1_Source_(__in_ecount_nz, (size), __in_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_bcount_nz(size) _SAL1_Source_(__in_bcount_nz, (size), __in_bcount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out _SAL1_Source_(__out, (), _Out_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount(size) _SAL1_Source_(__out_ecount, (size), _Out_writes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount(size) _SAL1_Source_(__out_bcount, (size), _Out_writes_bytes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_part(size,length) _SAL1_Source_(__out_ecount_part, (size,length), _Out_writes_to_(size,length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_part(size,length) _SAL1_Source_(__out_bcount_part, (size,length), _Out_writes_bytes_to_(size,length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_full(size) _SAL1_Source_(__out_ecount_full, (size), _Out_writes_all_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_full(size) _SAL1_Source_(__out_bcount_full, (size), _Out_writes_bytes_all_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_z _SAL1_Source_(__out_z, (), __post __valid __refparam __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_z_opt _SAL1_Source_(__out_z_opt, (), __post __valid __refparam __post __nullterminated __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_z(size) _SAL1_Source_(__out_ecount_z, (size), __ecount(size) __post __valid __refparam __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_z(size) _SAL1_Source_(__out_bcount_z, (size), __bcount(size) __post __valid __refparam __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_part_z(size,length) _SAL1_Source_(__out_ecount_part_z, (size,length), __out_ecount_part(size,length) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_part_z(size,length) _SAL1_Source_(__out_bcount_part_z, (size,length), __out_bcount_part(size,length) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_full_z(size) _SAL1_Source_(__out_ecount_full_z, (size), __out_ecount_full(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_full_z(size) _SAL1_Source_(__out_bcount_full_z, (size), __out_bcount_full(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_nz _SAL1_Source_(__out_nz, (), __post __valid __refparam)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_nz_opt _SAL1_Source_(__out_nz_opt, (), __post __valid __refparam __post_except_maybenull_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_nz(size) _SAL1_Source_(__out_ecount_nz, (size), __ecount(size) __post __valid __refparam)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_nz(size) _SAL1_Source_(__out_bcount_nz, (size), __bcount(size) __post __valid __refparam)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout _SAL1_Source_(__inout, (), _Inout_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount(size) _SAL1_Source_(__inout_ecount, (size), _Inout_updates_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount(size) _SAL1_Source_(__inout_bcount, (size), _Inout_updates_bytes_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_part(size,length) _SAL1_Source_(__inout_ecount_part, (size,length), _Inout_updates_to_(size,length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_part(size,length) _SAL1_Source_(__inout_bcount_part, (size,length), _Inout_updates_bytes_to_(size,length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_full(size) _SAL1_Source_(__inout_ecount_full, (size), _Inout_updates_all_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_full(size) _SAL1_Source_(__inout_bcount_full, (size), _Inout_updates_bytes_all_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_z _SAL1_Source_(__inout_z, (), _Inout_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_z(size) _SAL1_Source_(__inout_ecount_z, (size), _Inout_updates_z_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_z(size) _SAL1_Source_(__inout_bcount_z, (size), __inout_bcount(size) __pre __nullterminated __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_nz _SAL1_Source_(__inout_nz, (), __inout)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_nz(size) _SAL1_Source_(__inout_ecount_nz, (size), __inout_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_nz(size) _SAL1_Source_(__inout_bcount_nz, (size), __inout_bcount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __ecount_opt(size) _SAL1_Source_(__ecount_opt, (size), __ecount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __bcount_opt(size) _SAL1_Source_(__bcount_opt, (size), __bcount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_opt _SAL1_Source_(__in_opt, (), _In_opt_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_ecount_opt(size) _SAL1_Source_(__in_ecount_opt, (size), _In_reads_opt_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_bcount_opt(size) _SAL1_Source_(__in_bcount_opt, (size), _In_reads_bytes_opt_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_z_opt _SAL1_Source_(__in_z_opt, (), _In_opt_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_ecount_z_opt(size) _SAL1_Source_(__in_ecount_z_opt, (size), __in_ecount_opt(size) __pre __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_bcount_z_opt(size) _SAL1_Source_(__in_bcount_z_opt, (size), __in_bcount_opt(size) __pre __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_nz_opt _SAL1_Source_(__in_nz_opt, (), __in_opt)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_ecount_nz_opt(size) _SAL1_Source_(__in_ecount_nz_opt, (size), __in_ecount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __in_bcount_nz_opt(size) _SAL1_Source_(__in_bcount_nz_opt, (size), __in_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_opt _SAL1_Source_(__out_opt, (), _Out_opt_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_opt(size) _SAL1_Source_(__out_ecount_opt, (size), _Out_writes_opt_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_opt(size) _SAL1_Source_(__out_bcount_opt, (size), _Out_writes_bytes_opt_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_part_opt(size,length) _SAL1_Source_(__out_ecount_part_opt, (size,length), __out_ecount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_part_opt(size,length) _SAL1_Source_(__out_bcount_part_opt, (size,length), __out_bcount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_full_opt(size) _SAL1_Source_(__out_ecount_full_opt, (size), __out_ecount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_full_opt(size) _SAL1_Source_(__out_bcount_full_opt, (size), __out_bcount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_z_opt(size) _SAL1_Source_(__out_ecount_z_opt, (size), __out_ecount_opt(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_z_opt(size) _SAL1_Source_(__out_bcount_z_opt, (size), __out_bcount_opt(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_part_z_opt(size,length) _SAL1_Source_(__out_ecount_part_z_opt, (size,length), __out_ecount_part_opt(size,length) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_part_z_opt(size,length) _SAL1_Source_(__out_bcount_part_z_opt, (size,length), __out_bcount_part_opt(size,length) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_full_z_opt(size) _SAL1_Source_(__out_ecount_full_z_opt, (size), __out_ecount_full_opt(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_full_z_opt(size) _SAL1_Source_(__out_bcount_full_z_opt, (size), __out_bcount_full_opt(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_ecount_nz_opt(size) _SAL1_Source_(__out_ecount_nz_opt, (size), __out_ecount_opt(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __out_bcount_nz_opt(size) _SAL1_Source_(__out_bcount_nz_opt, (size), __out_bcount_opt(size) __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_opt _SAL1_Source_(__inout_opt, (), _Inout_opt_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_opt(size) _SAL1_Source_(__inout_ecount_opt, (size), __inout_ecount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_opt(size) _SAL1_Source_(__inout_bcount_opt, (size), __inout_bcount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_part_opt(size,length) _SAL1_Source_(__inout_ecount_part_opt, (size,length), __inout_ecount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_part_opt(size,length) _SAL1_Source_(__inout_bcount_part_opt, (size,length), __inout_bcount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_full_opt(size) _SAL1_Source_(__inout_ecount_full_opt, (size), __inout_ecount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_full_opt(size) _SAL1_Source_(__inout_bcount_full_opt, (size), __inout_bcount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_z_opt _SAL1_Source_(__inout_z_opt, (), __inout_opt __pre __nullterminated __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_z_opt(size) _SAL1_Source_(__inout_ecount_z_opt, (size), __inout_ecount_opt(size) __pre __nullterminated __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_z_opt(size) _SAL1_Source_(__inout_ecount_z_opt, (size), __inout_ecount_opt(size) __pre __nullterminated __post __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_z_opt(size) _SAL1_Source_(__inout_bcount_z_opt, (size), __inout_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_nz_opt _SAL1_Source_(__inout_nz_opt, (), __inout_opt)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_ecount_nz_opt(size) _SAL1_Source_(__inout_ecount_nz_opt, (size), __inout_ecount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __inout_bcount_nz_opt(size) _SAL1_Source_(__inout_bcount_nz_opt, (size), __inout_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_ecount(size) _SAL1_Source_(__deref_ecount, (size), _Notref_ __ecount(1) __post _Notref_ __elem_readableTo(1) __post _Notref_ __deref _Notref_ __notnull __post __deref __elem_writableTo(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_bcount(size) _SAL1_Source_(__deref_bcount, (size), _Notref_ __ecount(1) __post _Notref_ __elem_readableTo(1) __post _Notref_ __deref _Notref_ __notnull __post __deref __byte_writableTo(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out _SAL1_Source_(__deref_out, (), _Outptr_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount(size) _SAL1_Source_(__deref_out_ecount, (size), _Outptr_result_buffer_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount(size) _SAL1_Source_(__deref_out_bcount, (size), _Outptr_result_bytebuffer_(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_part(size,length) _SAL1_Source_(__deref_out_ecount_part, (size,length), _Outptr_result_buffer_to_(size,length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_part(size,length) _SAL1_Source_(__deref_out_bcount_part, (size,length), _Outptr_result_bytebuffer_to_(size,length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_full(size) _SAL1_Source_(__deref_out_ecount_full, (size), __deref_out_ecount_part(size,size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_full(size) _SAL1_Source_(__deref_out_bcount_full, (size), __deref_out_bcount_part(size,size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_z _SAL1_Source_(__deref_out_z, (), _Outptr_result_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_z(size) _SAL1_Source_(__deref_out_ecount_z, (size), __deref_out_ecount(size) __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_z(size) _SAL1_Source_(__deref_out_bcount_z, (size), __deref_out_bcount(size) __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_nz _SAL1_Source_(__deref_out_nz, (), __deref_out)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_nz(size) _SAL1_Source_(__deref_out_ecount_nz, (size), __deref_out_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_nz(size) _SAL1_Source_(__deref_out_bcount_nz, (size), __deref_out_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout _SAL1_Source_(__deref_inout, (), _Notref_ __notnull _Notref_ __elem_readableTo(1) __pre __deref __valid __post _Notref_ __deref __valid __refparam)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_z _SAL1_Source_(__deref_inout_z, (), __deref_inout __pre __deref __nullterminated __post _Notref_ __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount(size) _SAL1_Source_(__deref_inout_ecount, (size), __deref_inout __pre __deref __elem_writableTo(size) __post _Notref_ __deref __elem_writableTo(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount(size) _SAL1_Source_(__deref_inout_bcount, (size), __deref_inout __pre __deref __byte_writableTo(size) __post _Notref_ __deref __byte_writableTo(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_part(size,length) _SAL1_Source_(__deref_inout_ecount_part, (size,length), __deref_inout_ecount(size) __pre __deref __elem_readableTo(length) __post __deref __elem_readableTo(length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_part(size,length) _SAL1_Source_(__deref_inout_bcount_part, (size,length), __deref_inout_bcount(size) __pre __deref __byte_readableTo(length) __post __deref __byte_readableTo(length))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_full(size) _SAL1_Source_(__deref_inout_ecount_full, (size), __deref_inout_ecount_part(size,size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_full(size) _SAL1_Source_(__deref_inout_bcount_full, (size), __deref_inout_bcount_part(size,size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_z(size) _SAL1_Source_(__deref_inout_ecount_z, (size), __deref_inout_ecount(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_z(size) _SAL1_Source_(__deref_inout_bcount_z, (size), __deref_inout_bcount(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_nz _SAL1_Source_(__deref_inout_nz, (), __deref_inout)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_nz(size) _SAL1_Source_(__deref_inout_ecount_nz, (size), __deref_inout_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_nz(size) _SAL1_Source_(__deref_inout_bcount_nz, (size), __deref_inout_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_ecount_opt(size) _SAL1_Source_(__deref_ecount_opt, (size), __deref_ecount(size) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_bcount_opt(size) _SAL1_Source_(__deref_bcount_opt, (size), __deref_bcount(size) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_opt _SAL1_Source_(__deref_out_opt, (), __deref_out __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_opt(size) _SAL1_Source_(__deref_out_ecount_opt, (size), __deref_out_ecount(size) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_opt(size) _SAL1_Source_(__deref_out_bcount_opt, (size), __deref_out_bcount(size) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_part_opt(size,length) _SAL1_Source_(__deref_out_ecount_part_opt, (size,length), __deref_out_ecount_part(size,length) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_part_opt(size,length) _SAL1_Source_(__deref_out_bcount_part_opt, (size,length), __deref_out_bcount_part(size,length) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_full_opt(size) _SAL1_Source_(__deref_out_ecount_full_opt, (size), __deref_out_ecount_full(size) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_full_opt(size) _SAL1_Source_(__deref_out_bcount_full_opt, (size), __deref_out_bcount_full(size) __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_z_opt _SAL1_Source_(__deref_out_z_opt, (), _Outptr_result_maybenull_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_z_opt(size) _SAL1_Source_(__deref_out_ecount_z_opt, (size), __deref_out_ecount_opt(size) __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_z_opt(size) _SAL1_Source_(__deref_out_bcount_z_opt, (size), __deref_out_bcount_opt(size) __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_nz_opt _SAL1_Source_(__deref_out_nz_opt, (), __deref_out_opt)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_ecount_nz_opt(size) _SAL1_Source_(__deref_out_ecount_nz_opt, (size), __deref_out_ecount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_out_bcount_nz_opt(size) _SAL1_Source_(__deref_out_bcount_nz_opt, (size), __deref_out_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_opt _SAL1_Source_(__deref_inout_opt, (), __deref_inout __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_opt(size) _SAL1_Source_(__deref_inout_ecount_opt, (size), __deref_inout_ecount(size) __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_opt(size) _SAL1_Source_(__deref_inout_bcount_opt, (size), __deref_inout_bcount(size) __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_part_opt(size,length) _SAL1_Source_(__deref_inout_ecount_part_opt, (size,length), __deref_inout_ecount_part(size,length) __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_part_opt(size,length) _SAL1_Source_(__deref_inout_bcount_part_opt, (size,length), __deref_inout_bcount_part(size,length) __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_full_opt(size) _SAL1_Source_(__deref_inout_ecount_full_opt, (size), __deref_inout_ecount_full(size) __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_full_opt(size) _SAL1_Source_(__deref_inout_bcount_full_opt, (size), __deref_inout_bcount_full(size) __pre_deref_except_maybenull __post_deref_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_z_opt _SAL1_Source_(__deref_inout_z_opt, (), __deref_inout_opt __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_z_opt(size) _SAL1_Source_(__deref_inout_ecount_z_opt, (size), __deref_inout_ecount_opt(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_z_opt(size) _SAL1_Source_(__deref_inout_bcount_z_opt, (size), __deref_inout_bcount_opt(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_nz_opt _SAL1_Source_(__deref_inout_nz_opt, (), __deref_inout_opt)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_ecount_nz_opt(size) _SAL1_Source_(__deref_inout_ecount_nz_opt, (size), __deref_inout_ecount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_inout_bcount_nz_opt(size) _SAL1_Source_(__deref_inout_bcount_nz_opt, (size), __deref_inout_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_ecount(size) _SAL1_Source_(__deref_opt_ecount, (size), __deref_ecount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_bcount(size) _SAL1_Source_(__deref_opt_bcount, (size), __deref_bcount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out _SAL1_Source_(__deref_opt_out, (), _Outptr_opt_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_z _SAL1_Source_(__deref_opt_out_z, (), _Outptr_opt_result_z_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount(size) _SAL1_Source_(__deref_opt_out_ecount, (size), __deref_out_ecount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount(size) _SAL1_Source_(__deref_opt_out_bcount, (size), __deref_out_bcount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_part(size,length) _SAL1_Source_(__deref_opt_out_ecount_part, (size,length), __deref_out_ecount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_part(size,length) _SAL1_Source_(__deref_opt_out_bcount_part, (size,length), __deref_out_bcount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_full(size) _SAL1_Source_(__deref_opt_out_ecount_full, (size), __deref_out_ecount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_full(size) _SAL1_Source_(__deref_opt_out_bcount_full, (size), __deref_out_bcount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout _SAL1_Source_(__deref_opt_inout, (), _Inout_opt_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount(size) _SAL1_Source_(__deref_opt_inout_ecount, (size), __deref_inout_ecount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount(size) _SAL1_Source_(__deref_opt_inout_bcount, (size), __deref_inout_bcount(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_part(size,length) _SAL1_Source_(__deref_opt_inout_ecount_part, (size,length), __deref_inout_ecount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_part(size,length) _SAL1_Source_(__deref_opt_inout_bcount_part, (size,length), __deref_inout_bcount_part(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_full(size) _SAL1_Source_(__deref_opt_inout_ecount_full, (size), __deref_inout_ecount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_full(size) _SAL1_Source_(__deref_opt_inout_bcount_full, (size), __deref_inout_bcount_full(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_z _SAL1_Source_(__deref_opt_inout_z, (), __deref_opt_inout __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_z(size) _SAL1_Source_(__deref_opt_inout_ecount_z, (size), __deref_opt_inout_ecount(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_z(size) _SAL1_Source_(__deref_opt_inout_bcount_z, (size), __deref_opt_inout_bcount(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_nz _SAL1_Source_(__deref_opt_inout_nz, (), __deref_opt_inout)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_nz(size) _SAL1_Source_(__deref_opt_inout_ecount_nz, (size), __deref_opt_inout_ecount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_nz(size) _SAL1_Source_(__deref_opt_inout_bcount_nz, (size), __deref_opt_inout_bcount(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_ecount_opt(size) _SAL1_Source_(__deref_opt_ecount_opt, (size), __deref_ecount_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_bcount_opt(size) _SAL1_Source_(__deref_opt_bcount_opt, (size), __deref_bcount_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_opt _SAL1_Source_(__deref_opt_out_opt, (), _Outptr_opt_result_maybenull_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_opt(size) _SAL1_Source_(__deref_opt_out_ecount_opt, (size), __deref_out_ecount_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_opt(size) _SAL1_Source_(__deref_opt_out_bcount_opt, (size), __deref_out_bcount_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_part_opt(size,length) _SAL1_Source_(__deref_opt_out_ecount_part_opt, (size,length), __deref_out_ecount_part_opt(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_part_opt(size,length) _SAL1_Source_(__deref_opt_out_bcount_part_opt, (size,length), __deref_out_bcount_part_opt(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_full_opt(size) _SAL1_Source_(__deref_opt_out_ecount_full_opt, (size), __deref_out_ecount_full_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_full_opt(size) _SAL1_Source_(__deref_opt_out_bcount_full_opt, (size), __deref_out_bcount_full_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_z_opt _SAL1_Source_(__deref_opt_out_z_opt, (), __post __deref __valid __refparam __pre_except_maybenull __pre_deref_except_maybenull __post_deref_except_maybenull __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_z_opt(size) _SAL1_Source_(__deref_opt_out_ecount_z_opt, (size), __deref_opt_out_ecount_opt(size) __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_z_opt(size) _SAL1_Source_(__deref_opt_out_bcount_z_opt, (size), __deref_opt_out_bcount_opt(size) __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_nz_opt _SAL1_Source_(__deref_opt_out_nz_opt, (), __deref_opt_out_opt)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_ecount_nz_opt(size) _SAL1_Source_(__deref_opt_out_ecount_nz_opt, (size), __deref_opt_out_ecount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_out_bcount_nz_opt(size) _SAL1_Source_(__deref_opt_out_bcount_nz_opt, (size), __deref_opt_out_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_opt _SAL1_Source_(__deref_opt_inout_opt, (), __deref_inout_opt __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_opt(size) _SAL1_Source_(__deref_opt_inout_ecount_opt, (size), __deref_inout_ecount_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_opt(size) _SAL1_Source_(__deref_opt_inout_bcount_opt, (size), __deref_inout_bcount_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_part_opt(size,length) _SAL1_Source_(__deref_opt_inout_ecount_part_opt, (size,length), __deref_inout_ecount_part_opt(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_part_opt(size,length) _SAL1_Source_(__deref_opt_inout_bcount_part_opt, (size,length), __deref_inout_bcount_part_opt(size,length) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_full_opt(size) _SAL1_Source_(__deref_opt_inout_ecount_full_opt, (size), __deref_inout_ecount_full_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_full_opt(size) _SAL1_Source_(__deref_opt_inout_bcount_full_opt, (size), __deref_inout_bcount_full_opt(size) __pre_except_maybenull)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_z_opt _SAL1_Source_(__deref_opt_inout_z_opt, (), __deref_opt_inout_opt __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_z_opt(size) _SAL1_Source_(__deref_opt_inout_ecount_z_opt, (size), __deref_opt_inout_ecount_opt(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_z_opt(size) _SAL1_Source_(__deref_opt_inout_bcount_z_opt, (size), __deref_opt_inout_bcount_opt(size) __pre __deref __nullterminated __post __deref __nullterminated)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_nz_opt _SAL1_Source_(__deref_opt_inout_nz_opt, (), __deref_opt_inout_opt)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_ecount_nz_opt(size) _SAL1_Source_(__deref_opt_inout_ecount_nz_opt, (size), __deref_opt_inout_ecount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __deref_opt_inout_bcount_nz_opt(size) _SAL1_Source_(__deref_opt_inout_bcount_nz_opt, (size), __deref_opt_inout_bcount_opt(size))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __success(expr) _SAL1_1_Source_(__success, (expr), _Success_(expr))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __nullterminated _SAL1_Source_(__nullterminated, (), _Null_terminated_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __nullnullterminated _SAL1_Source_(__nullnulltermiated, (), _SAL_nop_impl_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __reserved _SAL1_Source_(__reserved, (), _Reserved_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __checkReturn _SAL1_Source_(__checkReturn, (), _Check_return_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __typefix(ctype) _SAL1_Source_(__typefix, (ctype), __inner_typefix(ctype))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __override __inner_override
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __callback __inner_callback
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __format_string _SAL1_1_Source_(__format_string, (), _Printf_format_string_)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __blocksOn(resource) _SAL_L_Source_(__blocksOn, (resource), __inner_blocksOn(resource))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __control_entrypoint(category) _SAL_L_Source_(__control_entrypoint, (category), __inner_control_entrypoint(category))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __data_entrypoint(category) _SAL_L_Source_(__data_entrypoint, (category), __inner_data_entrypoint(category))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __useHeader _Use_decl_anno_impl_
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __on_failure(annotes)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __on_failure(annotes) _SAL1_1_Source_(__on_failure, (annotes), _On_failure_impl_(annotes _SAL_nop_impl_))
//# Laniatus Games Studio Inc. | WARN: Statement interrupted by a preprocessor statement:
//The original statement from the file sal.h starts with:
//    __inner_fallthrough_dec
//Statements interrupted by the preprocessor cannot be processed by this intent.//MyInfo
//The remainder of the header file sal.h is ignored.

public class CPythonSystem : CSingleton<CPythonSystem>
{
		public enum EWindow
		{
			WINDOW_STATUS,
			WINDOW_INVENTORY,
			WINDOW_ABILITY,
			WINDOW_SOCIETY,
			WINDOW_JOURNAL,
			WINDOW_COMMAND,

			WINDOW_QUICK,
			WINDOW_GAUGE,
			WINDOW_MINIMAP,
			WINDOW_CHAT,

			WINDOW_MAX_NUM
		}

		public const int FREQUENCY_MAX_NUM = 30;
		public const int RESOLUTION_MAX_NUM = 100;

		public class SResolution
		{
			public uint width;
			public uint height;
			public uint bpp;

			public uint[] frequency = new uint[20];
			public byte frequency_count;
		}

		public class SWindowStatus
		{
			public int isVisible;
			public int isMinimized;

			public int ixPosition;
			public int iyPosition;
			public int iHeight;
		}

		public class SConfig
		{
			public uint width;
			public uint height;
			public uint bpp;
			public uint frequency;

			public bool is_software_cursor;
			public bool is_object_culling;
			public int iDistance;
			public int iShadowLevel;

			public float music_volume;
			public byte voice_volume;

			public int gamma;

			public int isSaveID;
			public string SaveID = new string(new char[20]);

			public bool bWindowed;
			public bool bDecompressDDS;
			public bool bNoSoundCard;
			public bool bUseDefaultIME;
			public byte bSoftwareTiling;
			public bool bViewChat;
			public bool bAlwaysShowName;
			public bool bShowDamage;
			public bool bShowSalesText;
			public bool bShowMonsterEffects;
			public bool bShowSkillEffects;
			public bool bShowBuffEffects;
			public bool bShowYang;
			public bool bFogMode;
		}

		public CPythonSystem()
		{
//# Laniatus Games Studio Inc. | TODO TASK: The memory management function 'memset' has no equivalent in C#:
			memset(m_Config, 0, sizeof(TConfig));

			m_poInterfaceHandler = null;

			SetDefaultConfig();

			LoadConfig();

			ChangeSystem();

			if (LoadInterfaceStatus())
			{
				m_isInterfaceConfig = true;
			}
			else
			{
				m_isInterfaceConfig = false;
			}
		}

		public virtual void Dispose()
		{
			Debug.Assert(m_poInterfaceHandler == null && "CPythonSystem MUST CLEAR!");
		}

		public void Clear()
		{
			SetInterfaceHandler(null);
		}

		public void SetInterfaceHandler(PyObject poHandler)
		{
			m_poInterfaceHandler = poHandler;
		}

		public void DestroyInterfaceHandler()
		{
			m_poInterfaceHandler = null;
		}

		public void SetDefaultConfig()
		{
//# Laniatus Games Studio Inc. | TODO TASK: The memory management function 'memset' has no equivalent in C#:
			memset(m_Config, 0, sizeof(m_Config));

			m_Config.width = 1024;
			m_Config.height = 768;
			m_Config.bpp = 32;
			m_Config.bWindowed = false;
			m_Config.is_software_cursor = false;
			m_Config.is_object_culling = true;
			m_Config.iDistance = 3;

			m_Config.gamma = 3;
			m_Config.music_volume = 1.0f;
			m_Config.voice_volume = 5;

			m_Config.bDecompressDDS = 0;
			m_Config.bSoftwareTiling = 0;
			m_Config.iShadowLevel = 3;
			m_Config.bViewChat = true;
			m_Config.bAlwaysShowName = true;
			m_Config.bShowDamage = true;
			m_Config.bShowSalesText = true;
			m_Config.bShowMonsterEffects = true;
			m_Config.bShowSkillEffects = true;
			m_Config.bShowBuffEffects = true;
			m_Config.bShowYang = true;
			m_Config.bFogMode = true;
		}

		public bool LoadConfig()
		{
			FILE fp = null;

			if (null == (fp = fopen("metin2.cfg", "rt")))
			{
				return false;
			}

			string buf = new string(new char[256]);
			string command = new string(new char[256]);
			string value = new string(new char[256]);

			while (fgets(buf, 256, fp))
			{
				if (sscanf(buf, " %s %s\n", command, value) == EOF)
				{
					break;
				}

				if (!stricmp(command, "WIDTH"))
				{
					m_Config.width = atoi(value);
				}
				else if (!stricmp(command, "HEIGHT"))
				{
					m_Config.height = atoi(value);
				}
				else if (!stricmp(command, "BPP"))
				{
					m_Config.bpp = atoi(value);
				}
				else if (!stricmp(command, "FREQUENCY"))
				{
					m_Config.frequency = atoi(value);
				}
				else if (!stricmp(command, "SOFTWARE_CURSOR"))
				{
					m_Config.is_software_cursor = atoi(value) ? true : false;
				}
				else if (!stricmp(command, "OBJECT_CULLING"))
				{
					m_Config.is_object_culling = atoi(value) ? true : false;
				}
				else if (!stricmp(command, "VISIBILITY"))
				{
					m_Config.iDistance = atoi(value);
				}
				else if (!stricmp(command, "MUSIC_VOLUME"))
				{
					if (strchr(value, '.') == 0)
					{
						m_Config.music_volume = Math.Pow(10.0f, (-1.0f + (((float) atoi(value)) / 5.0f)));
						if (atoi(value) == 0)
						{
							m_Config.music_volume = 0.0f;
						}
					}
					else
					{
						m_Config.music_volume = atof(value);
					}
				}
				else if (!stricmp(command, "VOICE_VOLUME"))
				{
					m_Config.voice_volume = (char) atoi(value);
				}
				else if (!stricmp(command, "GAMMA"))
				{
					m_Config.gamma = atoi(value);
				}
				else if (!stricmp(command, "IS_SAVE_ID"))
				{
					m_Config.isSaveID = atoi(value);
				}
				else if (!stricmp(command, "SAVE_ID"))
				{
					strncpy(m_Config.SaveID, value, 20);
				}
				else if (!stricmp(command, "PRE_LOADING_DELAY_TIME"))
				{
					g_iLoadingDelayTime = atoi(value);
				}
				else if (!stricmp(command, "WINDOWED"))
				{
					m_Config.bWindowed = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "USE_DEFAULT_IME"))
				{
					m_Config.bUseDefaultIME = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SOFTWARE_TILING"))
				{
					m_Config.bSoftwareTiling = atoi(value);
				}
				else if (!stricmp(command, "SHADOW_LEVEL"))
				{
					m_Config.iShadowLevel = atoi(value);
				}
				else if (!stricmp(command, "DECOMPRESSED_TEXTURE"))
				{
					m_Config.bDecompressDDS = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "NO_SOUND_CARD"))
				{
					m_Config.bNoSoundCard = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "VIEW_CHAT"))
				{
					m_Config.bViewChat = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "ALWAYS_VIEW_NAME"))
				{
					m_Config.bAlwaysShowName = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SHOW_DAMAGE"))
				{
					m_Config.bShowDamage = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SHOW_SALESTEXT"))
				{
					m_Config.bShowSalesText = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SHOW_MONSTER_EFFECTS"))
				{
					m_Config.bShowMonsterEffects = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SHOW_SKILL_EFFECTS"))
				{
					m_Config.bShowSkillEffects = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SHOW_BUFF_EFFECTS"))
				{
					m_Config.bShowBuffEffects = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "SHOW_YANG_TEXT"))
				{
					m_Config.bShowYang = atoi(value) == 1 ? true : false;
				}
				else if (!stricmp(command, "FOG_MODE_ON"))
				{
					m_Config.bFogMode = atoi(value) == 1 ? true : false;
				}
			}

			if (m_Config.bWindowed)
			{
				uint screen_width = GetSystemMetrics(SM_CXFULLSCREEN);
				uint screen_height = GetSystemMetrics(SM_CYFULLSCREEN);

				if (m_Config.width >= screen_width)
				{
					m_Config.width = screen_width;
				}
				if (m_Config.height >= screen_height)
				{
					m_Config.height = screen_height;
				}
			}

			m_OldConfig = m_Config;

			fclose(fp);
			return true;
		}

		public bool SaveConfig()
		{
			FILE fp;

			if (null == (fp = fopen("metin2.cfg", "wt")))
			{
				return false;
			}

			fprintf(fp, "WIDTH						%d\n" + "HEIGHT						%d\n" + "BPP						%d\n" + "FREQUENCY					%d\n" + "SOFTWARE_CURSOR			%d\n" + "OBJECT_CULLING				%d\n" + "VISIBILITY					%d\n" + "MUSIC_VOLUME				%.3f\n" + "VOICE_VOLUME				%d\n" + "GAMMA						%d\n" + "IS_SAVE_ID					%d\n" + "SAVE_ID					%s\n" + "PRE_LOADING_DELAY_TIME		%d\n" + "DECOMPRESSED_TEXTURE		%d\n", m_Config.width, m_Config.height, m_Config.bpp, m_Config.frequency, m_Config.is_software_cursor, m_Config.is_object_culling, m_Config.iDistance, m_Config.music_volume, m_Config.voice_volume, m_Config.gamma, m_Config.isSaveID, m_Config.SaveID, g_iLoadingDelayTime, m_Config.bDecompressDDS);

			if (m_Config.bWindowed == 1)
			{
				fprintf(fp, "WINDOWED				%d\n", m_Config.bWindowed);
			}
			if (m_Config.bViewChat == 0)
			{
				fprintf(fp, "VIEW_CHAT				%d\n", m_Config.bViewChat);
			}
			if (m_Config.bAlwaysShowName != true)
			{
				fprintf(fp, "ALWAYS_VIEW_NAME		%d\n", m_Config.bAlwaysShowName);
			}
			if (m_Config.bShowDamage == 0)
			{
				fprintf(fp, "SHOW_DAMAGE		%d\n", m_Config.bShowDamage);
			}
			if (m_Config.bShowSalesText == 0)
			{
				fprintf(fp, "SHOW_SALESTEXT		%d\n", m_Config.bShowSalesText);
			}

			if (m_Config.bShowMonsterEffects == 0)
			{
				fprintf(fp, "SHOW_MONSTER_EFFECTS	%d\n", m_Config.bShowMonsterEffects);
			}
			if (m_Config.bShowSkillEffects == 0)
			{
				fprintf(fp, "SHOW_SKILL_EFFECTS		%d\n", m_Config.bShowSkillEffects);
			}
			if (m_Config.bShowBuffEffects == 0)
			{
				fprintf(fp, "SHOW_BUFF_EFFECTS		%d\n", m_Config.bShowBuffEffects);
			}
			if (m_Config.bShowYang == 0)
			{
				fprintf(fp, "SHOW_YANG_TEXT		%d\n", m_Config.bShowYang);
			}
			if (m_Config.bFogMode == 0)
			{
				fprintf(fp, "FOG_MODE_ON		%d\n", m_Config.bFogMode);
			}

			fprintf(fp, "USE_DEFAULT_IME		%d\n", m_Config.bUseDefaultIME);
			fprintf(fp, "SOFTWARE_TILING		%d\n", m_Config.bSoftwareTiling);
			fprintf(fp, "SHADOW_LEVEL			%d\n", m_Config.iShadowLevel);
			fprintf(fp, "\n");

			fclose(fp);
			return true;
		}

		public void ApplyConfig()
		{
			if (m_OldConfig.gamma != m_Config.gamma)
			{
				float val = 1.0f;

				switch (m_Config.gamma)
				{
					case 0:
						val = 0.4f;
						break;
					case 1:
						val = 0.7f;
						break;
					case 2:
						val = 1.0f;
						break;
					case 3:
						val = 1.2f;
						break;
					case 4:
						val = 1.4f;
						break;
				}

				CPythonGraphic.Instance().SetGamma(val);
			}

			if (m_OldConfig.is_software_cursor != m_Config.is_software_cursor)
			{
				if (m_Config.is_software_cursor)
				{
					CPythonApplication.Instance().SetCursorMode(CPythonApplication.CURSOR_MODE_SOFTWARE);
				}
				else
				{
					CPythonApplication.Instance().SetCursorMode(CPythonApplication.CURSOR_MODE_HARDWARE);
				}
			}

			m_OldConfig = m_Config;

			ChangeSystem();
		}

//# Laniatus Games Studio Inc. | TODO TASK: The implementation of the following method could not be found:
//		void SetConfig(SConfig set_config);
		public SConfig GetConfig()
		{
			return m_Config;
		}

		public void ChangeSystem()
		{
			CSoundManager rkSndMgr = CSoundManager.Instance();
			rkSndMgr.SetMusicVolume(m_Config.music_volume);
			rkSndMgr.SetSoundVolumeGrade(m_Config.voice_volume);
		}

		public bool LoadInterfaceStatus()
		{
			FILE File;
			File = fopen("interface.cfg", "rb");

			if (File == null)
			{
				return false;
			}

			fread(m_WindowStatus, 1, sizeof(TWindowStatus) * WINDOW_MAX_NUM, File);
			fclose(File);
			return true;
		}

		public void SaveInterfaceStatus()
		{
			if (!m_poInterfaceHandler)
			{
				return;
			}

			PyCallClassMemberFunc(m_poInterfaceHandler, "OnSaveInterfaceStatus", Py_BuildValue("()"));

			FILE File;

			File = fopen("interface.cfg", "wb");

			if (File == null)
			{
				TraceError("Cannot open interface.cfg");
				return;
			}

			fwrite(m_WindowStatus, 1, sizeof(TWindowStatus) * WINDOW_MAX_NUM, File);
			fclose(File);
		}

		public bool isInterfaceConfig()
		{
			return m_isInterfaceConfig;
		}

		public SWindowStatus GetWindowStatusReference(int iIndex)
		{
			return m_WindowStatus[iIndex];
		}

		public uint GetWidth()
		{
			return m_Config.width;
		}

		public uint GetHeight()
		{
			return m_Config.height;
		}

		public uint GetBPP()
		{
			return m_Config.bpp;
		}

		public uint GetFrequency()
		{
			return m_Config.frequency;
		}

		public bool IsSoftwareCursor()
		{
			return m_Config.is_software_cursor;
		}

		public bool IsWindowed()
		{
			return m_Config.bWindowed;
		}

		public bool IsViewChat()
		{
			return m_Config.bViewChat;
		}

		public bool IsAlwaysShowName()
		{
			return m_Config.bAlwaysShowName;
		}

		public bool IsShowDamage()
		{
			return m_Config.bShowDamage;
		}

		public bool IsShowSalesText()
		{
			return m_Config.bShowSalesText;
		}

		public bool IsUseDefaultIME()
		{
			return m_Config.bUseDefaultIME;
		}

		public bool IsNoSoundCard()
		{
			return m_Config.bNoSoundCard;
		}

		public bool IsAutoTiling()
		{
			if (m_Config.bSoftwareTiling == 0)
			{
				return true;
			}

			return false;
		}

		public bool IsSoftwareTiling()
		{
			if (m_Config.bSoftwareTiling == 1)
			{
				return true;
			}

			return false;
		}

		public void SetSoftwareTiling(bool isEnable)
		{
			if (isEnable)
			{
				m_Config.bSoftwareTiling = 1;
			}
			else
			{
				m_Config.bSoftwareTiling = 2;
			}
		}

		public void SetViewChatFlag(int iFlag)
		{
			m_Config.bViewChat = iFlag == 1 ? true : false;
		}

		public void SetAlwaysShowNameFlag(int iFlag)
		{
			m_Config.bAlwaysShowName = iFlag == 1 ? true : false;
		}

		public void SetShowDamageFlag(int iFlag)
		{
			m_Config.bShowDamage = iFlag == 1 ? true : false;
		}

		public void SetShowSalesTextFlag(int iFlag)
		{
			m_Config.bShowSalesText = iFlag == 1 ? true : false;
		}

		public void SetShowMonsterEffects(int iFlag)
		{
			m_Config.bShowMonsterEffects = iFlag == 1 ? true : false;
			CPythonCharacterManager.instance().UpdateShowMonsterEffects(m_Config.bShowMonsterEffects);
		}

		public bool IsShowMonsterEffects()
		{
			return m_Config.bShowMonsterEffects;
		}

		public void SetShowSkillEffects(int iFlag)
		{
			m_Config.bShowSkillEffects = iFlag == 1 ? true : false;
			CEffectManager.Instance().HideOnSomeEffects(CEffectManager.BL_SKILL, iFlag);
		}

		public bool IsShowSkillEffects()
		{
			return m_Config.bShowSkillEffects;
		}

		public void SetShowBuffEffects(int iFlag)
		{
			m_Config.bShowBuffEffects = iFlag == 1 ? true : false;
			CEffectManager.Instance().HideOnSomeEffects(CEffectManager.BL_BUFF, iFlag);
		}

		public bool IsShowBuffEffects()
		{
			return m_Config.bShowBuffEffects;
		}

		public void SetShowYang(int iFlag)
		{
			m_Config.bShowYang = iFlag == 1 ? true : false;
		}

		public bool IsShowYang()
		{
			return m_Config.bShowYang;
		}

		public void SetFogMode(int iFlag)
		{
			m_Config.bFogMode = iFlag == 1 ? true : false;
		}

		public bool IsFogMode()
		{
			return m_Config.bFogMode;
		}

		public void SaveWindowStatus(int iIndex, int iVisible, int iMinimized, int ix, int iy, int iHeight)
		{
			m_WindowStatus[iIndex].isVisible = iVisible;
			m_WindowStatus[iIndex].isMinimized = iMinimized;
			m_WindowStatus[iIndex].ixPosition = ix;
			m_WindowStatus[iIndex].iyPosition = iy;
			m_WindowStatus[iIndex].iHeight = iHeight;
		}

		public int IsSaveID()
		{
			return m_Config.isSaveID;
		}

		public string GetSaveID()
		{
			return m_Config.SaveID;
		}

		public void SetSaveID(int iValue, string c_szSaveID)
		{
			if (iValue != 1)
			{
				return;
			}

			m_Config.isSaveID = iValue;
			strncpy(m_Config.SaveID, c_szSaveID, sizeof(m_Config.SaveID) - 1);
		}

		public void GetDisplaySettings()
		{
//# Laniatus Games Studio Inc. | TODO TASK: The memory management function 'memset' has no equivalent in C#:
			memset(m_ResolutionList, 0, sizeof(TResolution) * RESOLUTION_MAX_NUM);
			m_ResolutionCount = 0;

			LPDIRECT3D8 lpD3D = CPythonGraphic.Instance().GetD3D();

			D3DADAPTER_IDENTIFIER8 d3dAdapterIdentifier = new D3DADAPTER_IDENTIFIER8();
			D3DDISPLAYMODE d3ddmDesktop = new D3DDISPLAYMODE();

			lpD3D.GetAdapterIdentifier(0, D3DENUM_NO_WHQL_LEVEL, d3dAdapterIdentifier);
			lpD3D.GetAdapterDisplayMode(0, d3ddmDesktop);

			uint dwNumAdapterModes = lpD3D.GetAdapterModeCount(0);

			for (uint iMode = 0; iMode < dwNumAdapterModes; iMode++)
			{
				D3DDISPLAYMODE DisplayMode = new D3DDISPLAYMODE();
				lpD3D.EnumAdapterModes(0, iMode, DisplayMode);
				uint bpp = 0;

				if (DisplayMode.Width < 800 || DisplayMode.Height < 600)
				{
					continue;
				}

				if (DisplayMode.Format == D3DFMT_R5G6B5)
				{
					bpp = 16;
				}
				else if (DisplayMode.Format == D3DFMT_X8R8G8B8)
				{
					bpp = 32;
				}
				else
				{
					continue;
				}

				int check_res = false ? 1 : 0;

				for (int LaniatusDefVariables = 0; !check_res && LaniatusDefVariables < m_ResolutionCount; ++i)
				{
					if (m_ResolutionList[i].bpp != bpp || m_ResolutionList[i].width != DisplayMode.Width || m_ResolutionList[i].height != DisplayMode.Height)
					{
						continue;
					}

					int check_fre = false ? 1 : 0;

					for (int j = 0; j < m_ResolutionList[i].frequency_count; ++j)
					{
						if (m_ResolutionList[i].frequency[j] == DisplayMode.RefreshRate)
						{
							check_fre = true ? 1 : 0;
							break;
						}
					}

					if (check_fre == 0)
					{
						if (m_ResolutionList[i].frequency_count < FREQUENCY_MAX_NUM)
						{
							m_ResolutionList[i].frequency[m_ResolutionList[i].frequency_count++] = DisplayMode.RefreshRate;
						}
					}

					check_res = true ? 1 : 0;
				}

				if (check_res == 0)
				{
					if (m_ResolutionCount < RESOLUTION_MAX_NUM)
					{
						m_ResolutionList[m_ResolutionCount].width = DisplayMode.Width;
						m_ResolutionList[m_ResolutionCount].height = DisplayMode.Height;
						m_ResolutionList[m_ResolutionCount].bpp = bpp;
						m_ResolutionList[m_ResolutionCount].frequency[0] = DisplayMode.RefreshRate;
						m_ResolutionList[m_ResolutionCount].frequency_count = 1;

						++m_ResolutionCount;
					}
				}
			}
		}

		public int GetResolutionCount()
		{
			return m_ResolutionCount;
		}

		public int GetFrequencyCount(int index)
		{
			if (index >= m_ResolutionCount)
			{
				return 0;
			}

			return m_ResolutionList[index].frequency_count;
		}

		public bool GetResolution(int index, OUT uint width, OUT uint height, OUT uint bpp)
		{
			if (index >= m_ResolutionCount)
			{
				return false;
			}

			width = m_ResolutionList[index].width;
			height = m_ResolutionList[index].height;
			bpp = m_ResolutionList[index].bpp;
			return true;
		}

		public bool GetFrequency(int index, int freq_index, OUT uint frequncy)
		{
			if (index >= m_ResolutionCount)
			{
				return false;
			}

			if (freq_index >= m_ResolutionList[index].frequency_count)
			{
				return false;
			}

			frequncy = m_ResolutionList[index].frequency[freq_index];
			return true;
		}

		public int GetResolutionIndex(uint width, uint height, uint bit)
		{
			uint re_width;
			uint re_height;
			uint re_bit;
			int LaniatusDefVariables = 0;

			while (GetResolution(i, re_width, re_height, re_bit))
			{
				if (re_width == width)
				{
					if (re_height == height)
					{
						if (re_bit == bit)
						{
							return i;
						}
					}
				}
				i++;
			}

			return 0;
		}

		public int GetFrequencyIndex(int res_index, uint frequency)
		{
			uint re_frequency;
			int LaniatusDefVariables = 0;

			while (GetFrequency(res_index, i, re_frequency))
			{
				if (re_frequency == frequency)
				{
					return i;
				}

				i++;
			}

			return 0;
		}

		public bool isViewCulling()
		{
			return m_Config.is_object_culling;
		}

		public float GetMusicVolume()
		{
			return m_Config.music_volume;
		}

		public int GetSoundVolume()
		{
			return m_Config.voice_volume;
		}

		public void SetMusicVolume(float fVolume)
		{
			m_Config.music_volume = fVolume;
		}

		public void SetSoundVolumef(float fVolume)
		{
			m_Config.voice_volume = (int)(5 * fVolume);
		}

		public int GetDistance()
		{
			return m_Config.iDistance;
		}

		public int GetShadowLevel()
		{
			return m_Config.iShadowLevel;
		}

		public void SetShadowLevel(uint level)
		{
			m_Config.iShadowLevel = MIN(level, 5);
			CPythonBackground.instance().RefreshShadowLevel();
		}

		protected SResolution[] m_ResolutionList = Arrays.InitializeWithDefaultInstances<SResolution>(RESOLUTION_MAX_NUM);
		protected int m_ResolutionCount;

		protected SConfig m_Config = new SConfig();
		protected SConfig m_OldConfig = new SConfig();

		protected bool m_isInterfaceConfig;
		protected PyObject m_poInterfaceHandler;
		protected SWindowStatus[] m_WindowStatus = Arrays.InitializeWithDefaultInstances<SWindowStatus>(WINDOW_MAX_NUM);
}
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SAFE_RELEASE(p) { if (p) { (p)->Release(); (p)=NULL; } }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CHECK_RETURN(flag, string) if (flag) { LogBox(string); return; }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXINLINE __forceinline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXINLINE __inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXINLINE inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_DEFAULT ULONG_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_DEFAULT_FLOAT FLT_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_PI ((FLOAT) 3.141592654f)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_1BYPI ((FLOAT) 0.318309886f)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXToRadian( degree ) ((degree) * (D3DX_PI / 180.0f))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXToDegree( radian ) ((radian) * (180.0f / D3DX_PI))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define _ALIGN_16 __declspec(align(16))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXMATRIXA16 _ALIGN_16 _D3DXMATRIXA16
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXMatrixStack
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXBuffer
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXFont
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DrawText DrawTextW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DrawText DrawTextA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXSprite
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXRenderToSurface
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXRenderToEnvMap
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXASM_DEBUG (1 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXASM_SKIPVALIDATION (1 << 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXAssembleShaderFromFile D3DXAssembleShaderFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXAssembleShaderFromFile D3DXAssembleShaderFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXAssembleShaderFromResource D3DXAssembleShaderFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXAssembleShaderFromResource D3DXAssembleShaderFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXGetErrorString D3DXGetErrorStringW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXGetErrorString D3DXGetErrorStringA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_NONE (1 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_POINT (2 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_LINEAR (3 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_TRIANGLE (4 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_BOX (5 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_MIRROR_U (1 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_MIRROR_V (2 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_MIRROR_W (4 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_MIRROR (7 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_FILTER_DITHER (8 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_NORMALMAP_MIRROR_U (1 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_NORMALMAP_MIRROR_V (2 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_NORMALMAP_MIRROR (3 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_NORMALMAP_INVERTSIGN (8 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_NORMALMAP_COMPUTE_OCCLUSION (16 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_CHANNEL_RED (1 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_CHANNEL_BLUE (1 << 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_CHANNEL_GREEN (1 << 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_CHANNEL_ALPHA (1 << 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DX_CHANNEL_LUMINANCE (1 << 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXGetImageInfoFromFile D3DXGetImageInfoFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXGetImageInfoFromFile D3DXGetImageInfoFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXGetImageInfoFromResource D3DXGetImageInfoFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXGetImageInfoFromResource D3DXGetImageInfoFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadSurfaceFromFile D3DXLoadSurfaceFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadSurfaceFromFile D3DXLoadSurfaceFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadSurfaceFromResource D3DXLoadSurfaceFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadSurfaceFromResource D3DXLoadSurfaceFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXSaveSurfaceToFile D3DXSaveSurfaceToFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXSaveSurfaceToFile D3DXSaveSurfaceToFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadVolumeFromFile D3DXLoadVolumeFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadVolumeFromFile D3DXLoadVolumeFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadVolumeFromResource D3DXLoadVolumeFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXLoadVolumeFromResource D3DXLoadVolumeFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXSaveVolumeToFile D3DXSaveVolumeToFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXSaveVolumeToFile D3DXSaveVolumeToFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromFile D3DXCreateTextureFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromFile D3DXCreateTextureFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromFile D3DXCreateCubeTextureFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromFile D3DXCreateCubeTextureFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromFile D3DXCreateVolumeTextureFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromFile D3DXCreateVolumeTextureFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromResource D3DXCreateTextureFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromResource D3DXCreateTextureFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromResource D3DXCreateCubeTextureFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromResource D3DXCreateCubeTextureFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromResource D3DXCreateVolumeTextureFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromResource D3DXCreateVolumeTextureFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromFileEx D3DXCreateTextureFromFileExW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromFileEx D3DXCreateTextureFromFileExA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromFileEx D3DXCreateCubeTextureFromFileExW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromFileEx D3DXCreateCubeTextureFromFileExA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromFileEx D3DXCreateVolumeTextureFromFileExW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromFileEx D3DXCreateVolumeTextureFromFileExA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromResourceEx D3DXCreateTextureFromResourceExW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateTextureFromResourceEx D3DXCreateTextureFromResourceExA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromResourceEx D3DXCreateCubeTextureFromResourceExW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateCubeTextureFromResourceEx D3DXCreateCubeTextureFromResourceExA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromResourceEx D3DXCreateVolumeTextureFromResourceExW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateVolumeTextureFromResourceEx D3DXCreateVolumeTextureFromResourceExA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXSaveTextureToFile D3DXSaveTextureToFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXSaveTextureToFile D3DXSaveTextureToFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXFilterCubeTexture D3DXFilterTexture
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXFilterVolumeTexture D3DXFilterTexture
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WIN_TYPES(itype, ptype) typedef interface itype *LP##ptype, **LPLP##ptype
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define IUNKNOWN_METHODS(kind) STDMETHOD(QueryInterface) (THIS_ REFIID riid, LPVOID *ppvObj) kind; STDMETHOD_(ULONG, AddRef) (THIS) kind; STDMETHOD_(ULONG, Release) (THIS) kind
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define IDIRECTXFILEOBJECT_METHODS(kind) STDMETHOD(GetName) (THIS_ LPSTR, LPDWORD) kind; STDMETHOD(GetId) (THIS_ LPGUID) kind
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFile
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFileEnumObject
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFileSaveObject
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFileObject
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFileData
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFileDataReference
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE IDirectXFileBinary
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADOBJECT MAKE_DDHRESULT(850)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADVALUE MAKE_DDHRESULT(851)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADTYPE MAKE_DDHRESULT(852)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADSTREAMHANDLE MAKE_DDHRESULT(853)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADALLOC MAKE_DDHRESULT(854)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOTFOUND MAKE_DDHRESULT(855)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOTDONEYET MAKE_DDHRESULT(856)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_FILENOTFOUND MAKE_DDHRESULT(857)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_RESOURCENOTFOUND MAKE_DDHRESULT(858)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_URLNOTFOUND MAKE_DDHRESULT(859)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADRESOURCE MAKE_DDHRESULT(860)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADFILETYPE MAKE_DDHRESULT(861)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADFILEVERSION MAKE_DDHRESULT(862)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADFILEFLOATSIZE MAKE_DDHRESULT(863)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADFILECOMPRESSIONTYPE MAKE_DDHRESULT(864)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADFILE MAKE_DDHRESULT(865)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_PARSEERROR MAKE_DDHRESULT(866)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOTEMPLATE MAKE_DDHRESULT(867)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADARRAYSIZE MAKE_DDHRESULT(868)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADDATAREFERENCE MAKE_DDHRESULT(869)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_INTERNALERROR MAKE_DDHRESULT(870)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOMOREOBJECTS MAKE_DDHRESULT(871)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADINTRINSICS MAKE_DDHRESULT(872)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOMORESTREAMHANDLES MAKE_DDHRESULT(873)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOMOREDATA MAKE_DDHRESULT(874)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_BADCACHEFILE MAKE_DDHRESULT(875)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXFILEERR_NOINTERNET MAKE_DDHRESULT(876)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXBaseMesh
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXMesh
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXPMesh
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXSPMesh
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UNUSED16 (0xffff)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define UNUSED32 (0xffffffff)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXSkinMesh
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateText D3DXCreateTextW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateText D3DXCreateTextA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXFX_DONOTSAVESTATE (1 << 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define INTERFACE ID3DXEffect
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateEffectFromFile D3DXCreateEffectFromFileW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateEffectFromFile D3DXCreateEffectFromFileA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateEffectFromResource D3DXCreateEffectFromResourceW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DXCreateEffectFromResource D3DXCreateEffectFromResourceA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CHECK_D3DAPI(a) { HRESULT hr = (a); if (hr != S_OK) assert(!#a); }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define STATEMANAGER (CStateManager::Instance())
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GOTO_CHILD_NODE(TextFileLoader, Index) CTextFileLoader::CGotoChild Child(TextFileLoader, Index);
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define Clamp(x, min, max) x = (x<min ? min : x<max ? x : max);
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRAVITY D3DXVECTOR3(0.0f, 0.0f, -9.8f)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DFVF_POINT (D3DFVF_XYZ)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DFVF_PT (D3DFVF_XYZ|D3DFVF_TEX1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define D3DFVF_PDT (D3DFVF_XYZ|D3DFVF_DIFFUSE|D3DFVF_TEX1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __CYGWIN__ __CYGWIN32__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __IBMC__ __IBMCPP__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __INTEL_COMPILER __ICL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __AZTEC_C__ __VERSION
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ptrdiff_t long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __far far
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __near near
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cdecl cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __far far
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __huge huge
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __near near
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __pascal pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __huge huge
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cdecl _cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __far _far
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __huge _huge
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __near _near
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __pascal _pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __cdecl cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __pascal pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_STRINGIZE(x) #x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_MACRO_EXPAND(x) LZO_PP_STRINGIZE(x)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_CONCAT2(a,b) a ## b
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_CONCAT3(a,b,c) a ## b ## c
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_CONCAT4(a,b,c,d) a ## b ## c ## d
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_CONCAT5(a,b,c,d,e) a ## b ## c ## d ## e
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_ECONCAT2(a,b) LZO_PP_CONCAT2(a,b)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_ECONCAT3(a,b,c) LZO_PP_CONCAT3(a,b,c)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_ECONCAT4(a,b,c,d) LZO_PP_CONCAT4(a,b,c,d)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PP_ECONCAT5(a,b,c,d,e) LZO_PP_CONCAT5(a,b,c,d,e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_STRINGIZE(x) #x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_MACRO_EXPAND(x) LZO_CPP_STRINGIZE(x)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_CONCAT2(a,b) a ## b
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_CONCAT3(a,b,c) a ## b ## c
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_CONCAT4(a,b,c,d) a ## b ## c ## d
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_CONCAT5(a,b,c,d,e) a ## b ## c ## d ## e
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_ECONCAT2(a,b) LZO_CPP_CONCAT2(a,b)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_ECONCAT3(a,b,c) LZO_CPP_CONCAT3(a,b,c)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_ECONCAT4(a,b,c,d) LZO_CPP_CONCAT4(a,b,c,d)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CPP_ECONCAT5(a,b,c,d,e) LZO_CPP_CONCAT5(a,b,c,d,e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_MASK_GEN(o,b) (((((o) << ((b)-1)) - (o)) << 1) + (o))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_EXTERN_C extern "C"
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_EXTERN_C extern
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__CILLY__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(SDCC)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_PATHSCALE (__PATHCC__ * 0x10000L + __PATHCC_MINOR__ * 0x100 + __PATHCC_PATCHLEVEL__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER __PATHSCALE__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__INTEL_COMPILER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__POCC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_LLVM (__GNUC__ * 0x10000L + __GNUC_MINOR__ * 0x100 + __GNUC_PATCHLEVEL__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_LLVM (__GNUC__ * 0x10000L + __GNUC_MINOR__ * 0x100)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER __VERSION__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_GNUC (__GNUC__ * 0x10000L + __GNUC_MINOR__ * 0x100 + __GNUC_PATCHLEVEL__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_GNUC (__GNUC__ * 0x10000L + __GNUC_MINOR__ * 0x100)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_GNUC (__GNUC__ * 0x10000L)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER __VERSION__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__AZTEC_C__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__BORLANDC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(_RELEASE)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__DMC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__DECC)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__VER__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__IBMC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__C166__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__LCC_VERSION__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(_MSC_VER) "." LZO_PP_MACRO_EXPAND(_MSC_FULL_VER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(_MSC_VER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__MWERKS__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__PACIFIC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__PUREC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__SC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_SUNPROC __SUNPRO_C
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__SUNPRO_C)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_CC_SUNPROC __SUNPRO_CC
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__SUNPRO_CC)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__TINYC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__TSC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__WATCOMC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__TURBOC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_CCVER LZO_PP_MACRO_EXPAND(__ZTC__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_MM_AHSHIFT ((unsigned) _AHSHIFT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_MM_AHSHIFT ((unsigned) _AHSHIFT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_MM_AHSHIFT ((unsigned) _AHSHIFT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_MM_AHSHIFT ((unsigned) _AHSHIFT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_MM_AHSHIFT ((unsigned) _HShift)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SHORT (SIZEOF_SHORT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_INT (SIZEOF_INT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_LONG (SIZEOF_LONG)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_LONG_LONG (SIZEOF_LONG_LONG)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF___INT16 (SIZEOF___INT16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF___INT32 (SIZEOF___INT32)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF___INT64 (SIZEOF___INT64)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_VOID_P (SIZEOF_VOID_P)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SIZE_T (SIZEOF_SIZE_T)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T (SIZEOF_PTRDIFF_T)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_LSR(x,b) (((x)+0ul) >> (b))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_LONG_LONG LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SIZE_T LZO_SIZEOF_INT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T LZO_SIZEOF_INT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_VOID_P LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SIZE_T LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_WORDSIZE LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SIZE_T LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SIZE_T LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_VOID_P LZO_SIZEOF_LONG
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_WORDSIZE __LZO_WORDSIZE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_WORDSIZE LZO_SIZEOF_VOID_P
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_SIZE_T LZO_SIZEOF_VOID_P
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T LZO_SIZEOF_VOID_P
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_SIZEOF_PTRDIFF_T LZO_SIZEOF_SIZE_T
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_LIBC_UCLIBC (__UCLIBC_MAJOR__ * 0x10000L + __UCLIBC_MINOR__ * 0x100 + __UCLIBC_SUBLEVEL__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_LIBC_GLIBC (__GLIBC__ * 0x10000L + __GLIBC_MINOR__ * 0x100)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_LIBC_MSL __MSL__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_gnuc_extension__ __extension__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_gnuc_extension__ __extension__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_ua_volatile volatile
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_alignof(e) __alignof__(e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_alignof(e) __alignof__(e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_alignof(e) __alignof(e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline __inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline __inline__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline __inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline __inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline __inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline __inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_inline inline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_forceinline __inline__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_forceinline __forceinline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_forceinline __inline__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_forceinline __inline__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_forceinline __forceinline
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_noinline __declspec(noinline)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_noinline __declspec(noinline)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_noinline __declspec(noinline)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_noreturn __declspec(noreturn)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_noreturn __declspec(noreturn)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_nothrow __declspec(nothrow)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_nothrow __declspec(nothrow)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_restrict __restrict__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_restrict __restrict__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_restrict __restrict__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_restrict __restrict
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_likely(e) (__builtin_expect(!!(e),1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_unlikely(e) (__builtin_expect(!!(e),0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_likely(e) (__builtin_expect(!!(e),1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_unlikely(e) (__builtin_expect(!!(e),0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_likely(e) (__builtin_expect(!!(e),1))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_unlikely(e) (__builtin_expect(!!(e),0))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_likely(e) (e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_unlikely(e) (e)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) ((void) &var)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) if (&var) ; else
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) ((void) var)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) if (&var) ; else
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) {extern int __lzo_unused[1-2*!(sizeof(var)>0)];}
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) ((void) sizeof(var))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) ((void) var)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED(var) ((void) &var)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) ((void) func)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) if (func) ; else
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) ((void) &func)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) if (func) ; else
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) ((void) &func)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) {extern int __lzo_unused[1-2*!(sizeof((int)func)>0)];}
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_FUNC(func) ((void) func)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_LABEL(l) switch(0) case 1:goto l
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_LABEL(l) if (0) goto l
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UNUSED_LABEL(l) switch(0) case 1:goto l
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_DEFINE_UNINITIALIZED_VAR(type,var,init) type var = var
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_DEFINE_UNINITIALIZED_VAR(type,var,init) type var = init
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT_HEADER(e) extern int __lzo_cta[1-!(e)];
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT_HEADER(e) extern int __lzo_cta[1u-2*!(e)];
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT_HEADER(e) extern int __lzo_cta[1-!(e)];
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT_HEADER(e) extern int __lzo_cta[1-2*!(e)];
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT(e) {typedef int __lzo_cta_t[1-!(e)];}
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT(e) switch(0) case 1:case !(e):break;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT(e) switch(0) case 1:case !(e):break;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT(e) switch(0) case 1:case !(e):break;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_COMPILE_TIME_ASSERT(e) {typedef int __lzo_cta_t[1-2*!(e)];}
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_main __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_qsort __pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_qsort _stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_qsort __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_atexit __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_main __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_qsort __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler __pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler _stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler __clrcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler _far _cdecl _loadds
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler _far _cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler _cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_sighandler __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __lzo_cdecl_va __lzo_cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_ASM_CLOBBER "cc", "memory"
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_MM "." LZO_INFO_MM
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_PM "." LZO_INFO_ABI_PM
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_ENDIAN "." LZO_INFO_ABI_ENDIAN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_OSNAME LZO_INFO_OS "." LZO_INFO_OS_CONSOLE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_OSNAME LZO_INFO_OS "." LZO_INFO_OS_POSIX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_OSNAME LZO_INFO_OS
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_LIBC "." LZO_INFO_LIBC
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_INFOSTR_CCVER " " LZO_INFO_CCVER
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INFO_STRING LZO_INFO_ARCH __LZO_INFOSTR_MM __LZO_INFOSTR_PM __LZO_INFOSTR_ENDIAN " " __LZO_INFOSTR_OSNAME __LZO_INFOSTR_LIBC " " LZO_INFO_CC __LZO_INFOSTR_CCVER
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UINT32_C(c) c ## UL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UINT32_C(c) ((c) + 0U)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT_MIN (-1LL - LZO_INT_MAX)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UINT_MAX UINT_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT_MAX INT_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT_MIN INT_MIN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UINT_MAX ULONG_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT_MAX LONG_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT_MIN LONG_MIN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UINT32_MAX UINT_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT32_MAX INT_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT32_MIN INT_MIN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_UINT32_MAX ULONG_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT32_MAX LONG_MAX
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_INT32_MIN LONG_MIN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_xint lzo_uint
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_xint lzo_uint32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_MMODEL __huge
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_bytep unsigned char __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_charp char __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_voidp void __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_shortp short __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_ushortp unsigned short __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_uint32p lzo_uint32 __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_int32p lzo_int32 __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_uintp lzo_uint __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_intp lzo_int __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_xintp lzo_xint __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_voidpp lzo_voidp __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_bytepp lzo_bytep __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_byte unsigned char __LZO_MMODEL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_EXTERN_C extern "C"
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_EXTERN_C extern
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_CDECL __lzo_cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PUBLIC(_rettype) __LZO_EXPORT1 _rettype __LZO_EXPORT2 __LZO_CDECL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_EXTERN(_rettype) __LZO_EXTERN_C LZO_PUBLIC(_rettype)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PRIVATE(_rettype) static _rettype __LZO_CDECL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_callback_p lzo_callback_t __LZO_MMODEL *
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_sizeof_dict_t ((unsigned)sizeof(lzo_bytep))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_init() __lzo_init_v2(LZO_VERSION,(int)sizeof(short),(int)sizeof(int), (int)sizeof(long),(int)sizeof(lzo_uint32),(int)sizeof(lzo_uint), (int)lzo_sizeof_dict_t,(int)sizeof(char *),(int)sizeof(lzo_voidp), (int)sizeof(lzo_callback_t))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_PTR_ALIGN_UP(_ptr,_size) ((_ptr) + (lzo_uint) __lzo_align_gap((const lzo_voidp)(_ptr),(lzo_uint)(_size)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define __LZO_ENTRY __LZO_CDECL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_EXTERN_CDECL LZO_EXTERN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO_ALIGN LZO_PTR_ALIGN_UP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_compress_asm_t lzo_compress_t
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define lzo_decompress_asm_t lzo_decompress_t
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO1X_MEM_COMPRESS LZO1X_1_MEM_COMPRESS
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO1X_1_MEM_COMPRESS ((lzo_uint32) (16384L * lzo_sizeof_dict_t))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO1X_1_11_MEM_COMPRESS ((lzo_uint32) (2048L * lzo_sizeof_dict_t))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO1X_1_12_MEM_COMPRESS ((lzo_uint32) (4096L * lzo_sizeof_dict_t))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO1X_1_15_MEM_COMPRESS ((lzo_uint32) (32768L * lzo_sizeof_dict_t))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LZO1X_999_MEM_COMPRESS ((lzo_uint32) (14 * 16384L * sizeof(short)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GOTO_CHILD_NODE(TextFileLoader, Index) CTextFileLoader::CGotoChild Child(TextFileLoader, Index);
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DUMMYUNIONNAMEN(n)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DUMMYUNIONNAMEN(n) u##n
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CHECK_D3DAPI(a) { HRESULT hr = (a); if (hr != S_OK) assert(!#a); }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define STATEMANAGER (CStateManager::Instance())
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE __int64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE __int64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE __INT64_TYPE__
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) __declspec(dllimport) ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) __declspec(dllexport) ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) __declspec(dllimport) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) __declspec(dllexport) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) [DllImport("granny2.dll")] ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) [DllExport("granny2.dll")] ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) __declspec(dllimport) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) __declspec(dllexport) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) __declspec(dllimport) ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) __declspec(dllexport) ret __stdcall
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) __declspec(dllimport) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) __declspec(dllexport) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE __int64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXP(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_CALLBACK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNIMPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNEXPDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_64BIT_TYPE long long
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNLINK(ret) ret
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNLINKDATA(type) type
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNLINK(ret) GRANNY_DYNEXP(ret)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNLINKDATA(type) GRANNY_DYNEXPDATA(type)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNLINK(ret) GRANNY_DYNIMP(ret)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_DYNLINKDATA(type) GRANNY_DYNIMPDATA(type)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_NAMESPACE_BEING typedef char Ignored_RequireSemi
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_NAMESPACE_END typedef char Ignored_RequireSemi
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_NAMESPACE_BEGIN namespace granny { typedef char Ignored_RequireSemi
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_NAMESPACE_END } typedef char Ignored_RequireSemi
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY granny::
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_FORWARD_DECL_STRUCT(x) typedef struct granny_ ## x granny_ ## x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_FORWARD_DECL_OPAQUE_STRUCT(x) GRANNY_NAMESPACE_BEGIN; struct x; GRANNY_NAMESPACE_END; typedef struct GRANNY x granny_ ## x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_FORWARD_DECL_OPAQUE_STRUCT(x) GRANNY_FORWARD_DECL_STRUCT(x)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_STRUCT(x) public x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GRANNY_STRUCT(x) x
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RR_STRING_JOIN(arg1, arg2) RR_STRING_JOIN_DELAY(arg1, arg2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RR_STRING_JOIN_DELAY(arg1, arg2) RR_STRING_JOIN_IMMEDIATE(arg1, arg2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RR_STRING_JOIN_IMMEDIATE(arg1, arg2) arg1 ## arg2
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RR_NUMBERNAME(name) RR_STRING_JOIN(name,__COUNTER__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define RR_NUMBERNAME(name) RR_STRING_JOIN(name,__LINE__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyTypeSizeCheck(expr) typedef int RR_NUMBERNAME(GrannyTypeSizeCheck_) [(expr) ? 1 : -1]
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyCurrentGRNStandardTag (0x80000000 + 57)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyCloseFileReader(Reader) { if(Reader) {(*((Reader)->CloseFileReaderCallback))(Reader);} } typedef int __granny_require_semicolon
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyReadAtMost(Reader, Pos, Count, Buffer) (*((Reader)->ReadAtMostCallback))(Reader, Pos, Count, Buffer)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyReadExactly(Reader, Pos, Count, Buffer) ((*((Reader)->ReadAtMostCallback))(Reader, Pos, Count, Buffer) == Count)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyGetReaderSize(Reader, SizeVar) ((*((Reader)->GetReaderSizeCallback))(Reader, SizeVar))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyCloseFileWriter(Writer) { if (Writer) {(*(Writer)->DeleteFileWriterCallback)(Writer);} } typedef int __granny_require_semicolon
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyGetWriterPosition(Writer) (*((Writer)->SeekWriterCallback))(Writer, 0, 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannySeekWriterFromStart(Writer, OffsetInUInt8s) (*((Writer)->SeekWriterCallback))(Writer, OffsetInUInt8s, 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannySeekWriterFromEnd(Writer, OffsetInUInt8s) (*((Writer)->SeekWriterCallback))(Writer, OffsetInUInt8s, 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannySeekWriterFromCurrentPosition(Writer, OffsetInUInt8s) (*((Writer)->SeekWriterCallback))(Writer, OffsetInUInt8s, 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyWriteBytes(Writer, UInt8Count, WritePointer) (*((Writer)->WriteCallback))(Writer, UInt8Count, WritePointer)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyBeginWriterCRC(Writer) (*((Writer)->BeginCRCCallback))(Writer)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyEndWriterCRC(Writer) (*((Writer)->EndCRCCallback))(Writer)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyWriterIsCRCing(Writer) (((Writer)->CRCing))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumSystemFileNameSize (1 << 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumTempFileNameSize (1 << 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumMessageBufferSize (1 << 10)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumLogFileNameSize (1 << 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumNumberToStringBuffer (1 << 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumIKLinkCount (1 << 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumMIPLevelCount (1 << 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumVertexNameLength (1 << 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumUserData (1 << 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumBoneNameLength (1 << 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumChannelCount (1 << 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumChannelWidth (1 << 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumPolygonSides (1 << 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyBlockFileFixupCount (1 << 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMinimumAllocationsPerFixedBlock (1 << 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyFileCopyBufferSize (1 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyCRCCheckBufferSize (1 << 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyCurrentMODStandardTag ((GrannyCurrentGRNStandardTag) | ((MOD_VERSION_TAG) << 15))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannySPUTransformTrackNoCurve (0xffffffff)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyProductReleaseName release
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyProductTrademarks ProductName " is a registered trademark of " ProductCompanyName
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyVersionsMatch GrannyVersionsMatch_(GrannyProductMajorVersion, GrannyProductMinorVersion, GrannyProductBuildNumber, GrannyProductCustomization)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define GrannyMaximumWeightCount (1 << 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define COMBO_KEY DWORD
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAKE_COMBO_KEY(motion_mode, combo_type) ( (DWORD(motion_mode) << 16) | (DWORD(combo_type)) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define COMBO_KEY_GET_MOTION_MODE(key) ( WORD(DWORD(key) >> 16 & 0xFFFF) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define COMBO_KEY_GET_COMBO_TYPE(key) ( WORD(DWORD(key) & 0xFFFF) )
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILCALLBACK __pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILEXPORT cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXDEC extern
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILCALL cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define HIWORD(ptr) (((U32)ptr)>>16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define LOWORD(ptr) ((U16)((U32)ptr))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define FOURCC U32
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((U32)(U8)(ch0) | ((U32)(U8)(ch1) << 8) | ((U32)(U8)(ch2) << 16) | ((U32)(U8)(ch3) << 24 ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioFOURCC(w,x,y,z) MAKEFOURCC(w,x,y,z)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILLIBCALLBACK __pascal
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_DIR_UP ".." MSS_DIR_SEP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_DIR_UP_TWO MSS_DIR_UP MSS_DIR_UP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILLIBCALLBACK WINAPI
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINMMAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_ERROR (MMSYSERR_BASE + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_BADDEVICEID (MMSYSERR_BASE + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_NOTENABLED (MMSYSERR_BASE + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_ALLOCATED (MMSYSERR_BASE + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_INVALHANDLE (MMSYSERR_BASE + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_NODRIVER (MMSYSERR_BASE + 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_NOMEM (MMSYSERR_BASE + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_NOTSUPPORTED (MMSYSERR_BASE + 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_BADERRNUM (MMSYSERR_BASE + 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_INVALFLAG (MMSYSERR_BASE + 10)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_INVALPARAM (MMSYSERR_BASE + 11)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_HANDLEBUSY (MMSYSERR_BASE + 12)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_INVALIDALIAS (MMSYSERR_BASE + 13)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_BADDB (MMSYSERR_BASE + 14)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_KEYNOTFOUND (MMSYSERR_BASE + 15)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_READERROR (MMSYSERR_BASE + 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_WRITEERROR (MMSYSERR_BASE + 17)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_DELETEERROR (MMSYSERR_BASE + 18)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_VALNOTFOUND (MMSYSERR_BASE + 19)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_NODRIVERCB (MMSYSERR_BASE + 20)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_MOREDATA (MMSYSERR_BASE + 21)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMSYSERR_LASTERROR (MMSYSERR_BASE + 21)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CALLBACK_THREAD (CALLBACK_TASK)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_OVERRIDE(X) X##Implementation
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_OVERRIDE_DEF(X) X = API_SET_OVERRIDE(X)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_OVERRIDE_DEF(X) API_SET_LEGACY_OVERRIDE_DEF(X) PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LIBRARY(X)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET(X) X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_PRIVATE(X) X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_BY_ORDINAL(X,O,PO) X @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_BY_ORDINAL_PRIVATE(X,O,PO) X @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY(X,L) X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_PRIVATE(X,L) X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_BY_ORDINAL(X,L,O,PO) X @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_BY_ORDINAL_PRIVATE(X,L,O,PO) X @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET(X) X
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_PRIVATE(X) X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_BY_ORDINAL(X,O,PO) X @##O NONAME
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_BY_ORDINAL_PRIVATE(X,O,PO) X @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY(X,L) X
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_PRIVATE(X,L) X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_BY_ORDINAL(X,L,O,PO) X @##O NONAME
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_BY_ORDINAL_PRIVATE(X,L,O,PO) X @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET(X) X = _API_SET_LEGACY_TARGET##.##X
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_PRIVATE(X) X = _API_SET_LEGACY_TARGET##.##X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_BY_ORDINAL(X,O,PO) X = _API_SET_LEGACY_TARGET##.##PO @##O NONAME
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_BY_ORDINAL_PRIVATE(X,O,PO) X = _API_SET_LEGACY_TARGET##.##PO @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY(X,L) X = L##.##X
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_PRIVATE(X,L) X = L##.##X PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_BY_ORDINAL(X,L,O,PO) X = L##.##PO @##O NONAME
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LEGACY_BY_ORDINAL_PRIVATE(X,L,O,PO) X = L##.##PO @##O NONAME PRIVATE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define API_SET_LIBRARY(X) LIBRARY X
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINADVAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINBASEAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ZAWPROXYAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINUSERAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINABLEAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINABLEAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINCFGMGR32API DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINDEVQUERYAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINSWDEVICEAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CMAPI DECLSPEC_IMPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WINPATHCCHAPI WINBASEAPI
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciSendCommand mciSendCommandW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciSendCommand mciSendCommandA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciSendString mciSendStringW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciSendString mciSendStringA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciGetDeviceID mciGetDeviceIDW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciGetDeviceID mciGetDeviceIDA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciGetDeviceIDFromElementID mciGetDeviceIDFromElementIDW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciGetDeviceIDFromElementID mciGetDeviceIDFromElementIDA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciGetErrorString mciGetErrorStringW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mciGetErrorString mciGetErrorStringA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_INVALID_DEVICE_ID (MCIERR_BASE + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_UNRECOGNIZED_KEYWORD (MCIERR_BASE + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_UNRECOGNIZED_COMMAND (MCIERR_BASE + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_HARDWARE (MCIERR_BASE + 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_INVALID_DEVICE_NAME (MCIERR_BASE + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_OUT_OF_MEMORY (MCIERR_BASE + 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_OPEN (MCIERR_BASE + 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_CANNOT_LOAD_DRIVER (MCIERR_BASE + 10)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_MISSING_COMMAND_STRING (MCIERR_BASE + 11)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_PARAM_OVERFLOW (MCIERR_BASE + 12)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_MISSING_STRING_ARGUMENT (MCIERR_BASE + 13)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_BAD_INTEGER (MCIERR_BASE + 14)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_PARSER_INTERNAL (MCIERR_BASE + 15)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DRIVER_INTERNAL (MCIERR_BASE + 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_MISSING_PARAMETER (MCIERR_BASE + 17)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_UNSUPPORTED_FUNCTION (MCIERR_BASE + 18)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_FILE_NOT_FOUND (MCIERR_BASE + 19)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_NOT_READY (MCIERR_BASE + 20)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_INTERNAL (MCIERR_BASE + 21)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DRIVER (MCIERR_BASE + 22)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_CANNOT_USE_ALL (MCIERR_BASE + 23)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_MULTIPLE (MCIERR_BASE + 24)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_EXTENSION_NOT_FOUND (MCIERR_BASE + 25)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_OUTOFRANGE (MCIERR_BASE + 26)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_FLAGS_NOT_COMPATIBLE (MCIERR_BASE + 28)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_FILE_NOT_SAVED (MCIERR_BASE + 30)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_TYPE_REQUIRED (MCIERR_BASE + 31)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_LOCKED (MCIERR_BASE + 32)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DUPLICATE_ALIAS (MCIERR_BASE + 33)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_BAD_CONSTANT (MCIERR_BASE + 34)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_MUST_USE_SHAREABLE (MCIERR_BASE + 35)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_MISSING_DEVICE_NAME (MCIERR_BASE + 36)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_BAD_TIME_FORMAT (MCIERR_BASE + 37)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NO_CLOSING_QUOTE (MCIERR_BASE + 38)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DUPLICATE_FLAGS (MCIERR_BASE + 39)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_INVALID_FILE (MCIERR_BASE + 40)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NULL_PARAMETER_BLOCK (MCIERR_BASE + 41)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_UNNAMED_RESOURCE (MCIERR_BASE + 42)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NEW_REQUIRES_ALIAS (MCIERR_BASE + 43)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NOTIFY_ON_AUTO_OPEN (MCIERR_BASE + 44)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NO_ELEMENT_ALLOWED (MCIERR_BASE + 45)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NONAPPLICABLE_FUNCTION (MCIERR_BASE + 46)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_ILLEGAL_FOR_AUTO_OPEN (MCIERR_BASE + 47)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_FILENAME_REQUIRED (MCIERR_BASE + 48)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_EXTRA_CHARACTERS (MCIERR_BASE + 49)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_NOT_INSTALLED (MCIERR_BASE + 50)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_GET_CD (MCIERR_BASE + 51)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SET_CD (MCIERR_BASE + 52)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SET_DRIVE (MCIERR_BASE + 53)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_LENGTH (MCIERR_BASE + 54)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_DEVICE_ORD_LENGTH (MCIERR_BASE + 55)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NO_INTEGER (MCIERR_BASE + 56)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_OUTPUTSINUSE (MCIERR_BASE + 64)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_SETOUTPUTINUSE (MCIERR_BASE + 65)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_INPUTSINUSE (MCIERR_BASE + 66)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_SETINPUTINUSE (MCIERR_BASE + 67)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_OUTPUTUNSPECIFIED (MCIERR_BASE + 68)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_INPUTUNSPECIFIED (MCIERR_BASE + 69)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_OUTPUTSUNSUITABLE (MCIERR_BASE + 70)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_SETOUTPUTUNSUITABLE (MCIERR_BASE + 71)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_INPUTSUNSUITABLE (MCIERR_BASE + 72)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_WAVE_SETINPUTUNSUITABLE (MCIERR_BASE + 73)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_DIV_INCOMPATIBLE (MCIERR_BASE + 80)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_PORT_INUSE (MCIERR_BASE + 81)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_PORT_NONEXISTENT (MCIERR_BASE + 82)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_PORT_MAPNODEVICE (MCIERR_BASE + 83)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_PORT_MISCERROR (MCIERR_BASE + 84)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_TIMER (MCIERR_BASE + 85)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_PORTUNSPECIFIED (MCIERR_BASE + 86)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_SEQ_NOMIDIPRESENT (MCIERR_BASE + 87)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NO_WINDOW (MCIERR_BASE + 90)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_CREATEWINDOW (MCIERR_BASE + 91)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_FILE_READ (MCIERR_BASE + 92)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_FILE_WRITE (MCIERR_BASE + 93)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_NO_IDENTITY (MCIERR_BASE + 94)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCIERR_CUSTOM_DRIVER_BASE (MCIERR_BASE + 256)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_FIRST DRV_MCI_FIRST
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_USER_MESSAGES (DRV_MCI_FIRST + 0x400)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_ALL_DEVICE_ID ((MCIDEVICEID)-1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_DEVTYPE_FIRST MCI_DEVTYPE_VCR
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_DEVTYPE_LAST MCI_DEVTYPE_SEQUENCER
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_NOT_READY (MCI_STRING_OFFSET + 12)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_STOP (MCI_STRING_OFFSET + 13)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_PLAY (MCI_STRING_OFFSET + 14)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_RECORD (MCI_STRING_OFFSET + 15)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_SEEK (MCI_STRING_OFFSET + 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_PAUSE (MCI_STRING_OFFSET + 17)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MODE_OPEN (MCI_STRING_OFFSET + 18)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MSF_MINUTE(msf) ((BYTE)(msf))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MSF_SECOND(msf) ((BYTE)(((WORD)(msf)) >> 8))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MSF_FRAME(msf) ((BYTE)((msf)>>16))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MAKE_MSF(m, s, f) ((DWORD)(((BYTE)(m) | ((WORD)(s)<<8)) | (((DWORD)(BYTE)(f))<<16)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_TMSF_TRACK(tmsf) ((BYTE)(tmsf))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_TMSF_MINUTE(tmsf) ((BYTE)(((WORD)(tmsf)) >> 8))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_TMSF_SECOND(tmsf) ((BYTE)((tmsf)>>16))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_TMSF_FRAME(tmsf) ((BYTE)((tmsf)>>24))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MAKE_TMSF(t, m, s, f) ((DWORD)(((BYTE)(t) | ((WORD)(m)<<8)) | (((DWORD)(BYTE)(s) | ((WORD)(f)<<8))<<16)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_HMS_HOUR(hms) ((BYTE)(hms))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_HMS_MINUTE(hms) ((BYTE)(((WORD)(hms)) >> 8))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_HMS_SECOND(hms) ((BYTE)((hms)>>16))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_MAKE_HMS(h, m, s) ((DWORD)(((BYTE)(h) | ((WORD)(m)<<8)) | (((DWORD)(BYTE)(s))<<16)))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_VD_MODE_PARK (MCI_VD_OFFSET + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_VD_MEDIA_CLV (MCI_VD_OFFSET + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_VD_MEDIA_CAV (MCI_VD_OFFSET + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_VD_MEDIA_OTHER (MCI_VD_OFFSET + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_CDA_TRACK_AUDIO (MCI_CD_OFFSET + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_CDA_TRACK_OTHER (MCI_CD_OFFSET + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_WAVE_PCM (MCI_WAVE_OFFSET + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_WAVE_MAPPER (MCI_WAVE_OFFSET + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_SEQ_DIV_PPQN (0 + MCI_SEQ_OFFSET)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_SEQ_DIV_SMPTE_24 (1 + MCI_SEQ_OFFSET)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_SEQ_DIV_SMPTE_25 (2 + MCI_SEQ_OFFSET)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_SEQ_DIV_SMPTE_30DROP (3 + MCI_SEQ_OFFSET)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MCI_SEQ_DIV_SMPTE_30 (4 + MCI_SEQ_OFFSET)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DefDriverProc DrvDefDriverProc
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DRV_CANCEL DRVCNF_CANCEL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DRV_OK DRVCNF_OK
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DRV_RESTART DRVCNF_RESTART
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DRV_MCI_FIRST DRV_RESERVED
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DRV_MCI_LAST (DRV_RESERVED + 0xFFF)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_FILENOTFOUND (MMIOERR_BASE + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_OUTOFMEMORY (MMIOERR_BASE + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CANNOTOPEN (MMIOERR_BASE + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CANNOTCLOSE (MMIOERR_BASE + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CANNOTREAD (MMIOERR_BASE + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CANNOTWRITE (MMIOERR_BASE + 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CANNOTSEEK (MMIOERR_BASE + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CANNOTEXPAND (MMIOERR_BASE + 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_CHUNKNOTFOUND (MMIOERR_BASE + 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_UNBUFFERED (MMIOERR_BASE + 10)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_PATHNOTFOUND (MMIOERR_BASE + 11)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_ACCESSDENIED (MMIOERR_BASE + 12)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_SHARINGVIOLATION (MMIOERR_BASE + 13)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_NETWORKERROR (MMIOERR_BASE + 14)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_TOOMANYOPENFILES (MMIOERR_BASE + 15)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOERR_INVALIDFILE (MMIOERR_BASE + 16)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOM_READ MMIO_READ
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MMIOM_WRITE MMIO_WRITE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define FOURCC_RIFF mmioFOURCC('R', 'I', 'F', 'F')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define FOURCC_LIST mmioFOURCC('L', 'I', 'S', 'T')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define FOURCC_DOS mmioFOURCC('D', 'O', 'S', ' ')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define FOURCC_MEM mmioFOURCC('M', 'E', 'M', ' ')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioFOURCC(ch0, ch1, ch2, ch3) MAKEFOURCC(ch0, ch1, ch2, ch3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioStringToFOURCC mmioStringToFOURCCW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioStringToFOURCC mmioStringToFOURCCA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioInstallIOProc mmioInstallIOProcW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioInstallIOProc mmioInstallIOProcA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioOpen mmioOpenW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioOpen mmioOpenA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioRename mmioRenameW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mmioRename mmioRenameA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define sndPlaySound sndPlaySoundW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define sndPlaySound sndPlaySoundA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define sndAlias(ch0, ch1) (SND_ALIAS_START + (DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMASTERISK sndAlias('S', '*')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMQUESTION sndAlias('S', '?')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMHAND sndAlias('S', 'H')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMEXIT sndAlias('S', 'E')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMSTART sndAlias('S', 'S')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMWELCOME sndAlias('S', 'W')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMEXCLAMATION sndAlias('S', '!')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SND_ALIAS_SYSTEMDEFAULT sndAlias('S', 'D')
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PlaySound PlaySoundW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define PlaySound PlaySoundA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVERR_BADFORMAT (WAVERR_BASE + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVERR_STILLPLAYING (WAVERR_BASE + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVERR_UNPREPARED (WAVERR_BASE + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVERR_SYNC (WAVERR_BASE + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVERR_LASTERROR (WAVERR_BASE + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WOM_OPEN MM_WOM_OPEN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WOM_CLOSE MM_WOM_CLOSE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WOM_DONE MM_WOM_DONE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WIM_OPEN MM_WIM_OPEN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WIM_CLOSE MM_WIM_CLOSE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WIM_DATA MM_WIM_DATA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVE_MAPPER ((UINT)-1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define WAVE_FORMAT_DIRECT_QUERY (WAVE_FORMAT_QUERY | WAVE_FORMAT_DIRECT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveOutGetDevCaps waveOutGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveOutGetDevCaps waveOutGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveOutGetErrorText waveOutGetErrorTextW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveOutGetErrorText waveOutGetErrorTextA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveInGetDevCaps waveInGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveInGetDevCaps waveInGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveInGetErrorText waveInGetErrorTextW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define waveInGetErrorText waveInGetErrorTextA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_UNPREPARED (MIDIERR_BASE + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_STILLPLAYING (MIDIERR_BASE + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_NOMAP (MIDIERR_BASE + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_NOTREADY (MIDIERR_BASE + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_NODEVICE (MIDIERR_BASE + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_INVALIDSETUP (MIDIERR_BASE + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_BADOPENMODE (MIDIERR_BASE + 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_DONT_CONTINUE (MIDIERR_BASE + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIERR_LASTERROR (MIDIERR_BASE + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_OPEN MM_MIM_OPEN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_CLOSE MM_MIM_CLOSE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_DATA MM_MIM_DATA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_LONGDATA MM_MIM_LONGDATA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_ERROR MM_MIM_ERROR
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_LONGERROR MM_MIM_LONGERROR
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MOM_OPEN MM_MOM_OPEN
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MOM_CLOSE MM_MOM_CLOSE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MOM_DONE MM_MOM_DONE
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIM_MOREDATA MM_MIM_MOREDATA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MOM_POSITIONCB MM_MOM_POSITIONCB
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDIMAPPER ((UINT)-1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIDI_MAPPER ((UINT)-1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_EVENTTYPE(x) ((BYTE)(((x)>>24)&0xFF))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_EVENTPARM(x) ((DWORD)((x)&0x00FFFFFFL))
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_SHORTMSG ((BYTE)0x00)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_TEMPO ((BYTE)0x01)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_NOP ((BYTE)0x02)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_LONGMSG ((BYTE)0x80)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_COMMENT ((BYTE)0x82)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MEVT_VERSION ((BYTE)0x84)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiOutGetDevCaps midiOutGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiOutGetDevCaps midiOutGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiOutGetErrorText midiOutGetErrorTextW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiOutGetErrorText midiOutGetErrorTextA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiInGetDevCaps midiInGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiInGetDevCaps midiInGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiInGetErrorText midiInGetErrorTextW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define midiInGetErrorText midiInGetErrorTextA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AUX_MAPPER ((UINT)-1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define auxGetDevCaps auxGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define auxGetDevCaps auxGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERR_INVALLINE (MIXERR_BASE + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERR_INVALCONTROL (MIXERR_BASE + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERR_INVALVALUE (MIXERR_BASE + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERR_LASTERROR (MIXERR_BASE + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXER_OBJECTF_HMIXER (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIXER)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXER_OBJECTF_HWAVEOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEOUT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXER_OBJECTF_HWAVEIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_WAVEIN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXER_OBJECTF_HMIDIOUT (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIOUT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXER_OBJECTF_HMIDIIN (MIXER_OBJECTF_HANDLE|MIXER_OBJECTF_MIDIIN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetDevCaps mixerGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetDevCaps mixerGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_UNDEFINED (MIXERLINE_COMPONENTTYPE_DST_FIRST + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_DIGITAL (MIXERLINE_COMPONENTTYPE_DST_FIRST + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_LINE (MIXERLINE_COMPONENTTYPE_DST_FIRST + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_MONITOR (MIXERLINE_COMPONENTTYPE_DST_FIRST + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_SPEAKERS (MIXERLINE_COMPONENTTYPE_DST_FIRST + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_HEADPHONES (MIXERLINE_COMPONENTTYPE_DST_FIRST + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_TELEPHONE (MIXERLINE_COMPONENTTYPE_DST_FIRST + 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_WAVEIN (MIXERLINE_COMPONENTTYPE_DST_FIRST + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_VOICEIN (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_DST_LAST (MIXERLINE_COMPONENTTYPE_DST_FIRST + 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_UNDEFINED (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 0)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_DIGITAL (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_LINE (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_MICROPHONE (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_SYNTHESIZER (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_COMPACTDISC (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_TELEPHONE (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_PCSPEAKER (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_WAVEOUT (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 8)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_AUXILIARY (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 9)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_ANALOG (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERLINE_COMPONENTTYPE_SRC_LAST (MIXERLINE_COMPONENTTYPE_SRC_FIRST + 10)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetLineInfo mixerGetLineInfoW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetLineInfo mixerGetLineInfoA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_CUSTOM (MIXERCONTROL_CT_CLASS_CUSTOM | MIXERCONTROL_CT_UNITS_CUSTOM)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_BOOLEANMETER (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_BOOLEAN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_SIGNEDMETER (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_SIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_PEAKMETER (MIXERCONTROL_CONTROLTYPE_SIGNEDMETER + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_UNSIGNEDMETER (MIXERCONTROL_CT_CLASS_METER | MIXERCONTROL_CT_SC_METER_POLLED | MIXERCONTROL_CT_UNITS_UNSIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_BOOLEAN (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BOOLEAN | MIXERCONTROL_CT_UNITS_BOOLEAN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_ONOFF (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MUTE (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MONO (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_LOUDNESS (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_STEREOENH (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_BASS_BOOST (MIXERCONTROL_CONTROLTYPE_BOOLEAN + 0x00002277)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_BUTTON (MIXERCONTROL_CT_CLASS_SWITCH | MIXERCONTROL_CT_SC_SWITCH_BUTTON | MIXERCONTROL_CT_UNITS_BOOLEAN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_DECIBELS (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_DECIBELS)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_SIGNED (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_SIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_UNSIGNED (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_UNSIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_PERCENT (MIXERCONTROL_CT_CLASS_NUMBER | MIXERCONTROL_CT_UNITS_PERCENT)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_SLIDER (MIXERCONTROL_CT_CLASS_SLIDER | MIXERCONTROL_CT_UNITS_SIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_PAN (MIXERCONTROL_CONTROLTYPE_SLIDER + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_QSOUNDPAN (MIXERCONTROL_CONTROLTYPE_SLIDER + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_FADER (MIXERCONTROL_CT_CLASS_FADER | MIXERCONTROL_CT_UNITS_UNSIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_VOLUME (MIXERCONTROL_CONTROLTYPE_FADER + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_BASS (MIXERCONTROL_CONTROLTYPE_FADER + 2)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_TREBLE (MIXERCONTROL_CONTROLTYPE_FADER + 3)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_EQUALIZER (MIXERCONTROL_CONTROLTYPE_FADER + 4)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_SINGLESELECT (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_SINGLE | MIXERCONTROL_CT_UNITS_BOOLEAN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MUX (MIXERCONTROL_CONTROLTYPE_SINGLESELECT + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT (MIXERCONTROL_CT_CLASS_LIST | MIXERCONTROL_CT_SC_LIST_MULTIPLE | MIXERCONTROL_CT_UNITS_BOOLEAN)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MIXER (MIXERCONTROL_CONTROLTYPE_MULTIPLESELECT + 1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MICROTIME (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MICROSECS | MIXERCONTROL_CT_UNITS_UNSIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MIXERCONTROL_CONTROLTYPE_MILLITIME (MIXERCONTROL_CT_CLASS_TIME | MIXERCONTROL_CT_SC_TIME_MILLISECS | MIXERCONTROL_CT_UNITS_UNSIGNED)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetLineControls mixerGetLineControlsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetLineControls mixerGetLineControlsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetControlDetails mixerGetControlDetailsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define mixerGetControlDetails mixerGetControlDetailsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define TIMERR_NOCANDO (TIMERR_BASE+1)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define TIMERR_STRUCT (TIMERR_BASE+33)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define JOYERR_PARMS (JOYERR_BASE+5)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define JOYERR_NOCANDO (JOYERR_BASE+6)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define JOYERR_UNPLUGGED (JOYERR_BASE+7)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define JOY_POVCENTERED (WORD) -1
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define JOY_RETURNALL (JOY_RETURNX | JOY_RETURNY | JOY_RETURNZ | JOY_RETURNR | JOY_RETURNU | JOY_RETURNV | JOY_RETURNPOV | JOY_RETURNBUTTONS)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define joyGetDevCaps joyGetDevCapsW
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define joyGetDevCaps joyGetDevCapsA
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DIBINDEX(n) MAKELONG((n),0x10FF)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_MAIN_DEF __cdecl
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILEXPORT WINAPI
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXDEC __declspec(dllexport)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXDEF __declspec(dllexport)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXDEC extern
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXDEC __declspec(dllimport)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_DIR_UP ".." MSS_DIR_SEP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_DIR_UP_TWO MSS_DIR_UP MSS_DIR_UP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILEXPORT __export WINAPI
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DXDEC extern
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_DIR_UP ".." MSS_DIR_SEP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define MSS_DIR_UP_TWO MSS_DIR_UP MSS_DIR_UP
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILCALL WINAPI
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define AILCALLBACK AILEXPORT
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define NAMESPACE_BEGIN(x)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DOCUMENTED_TYPEDEF(x, y) class y : public x {};
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define NAMESPACE_BEGIN(x) namespace x {
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define NAMESPACE_END }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DOCUMENTED_TYPEDEF(x, y) typedef x y;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ANONYMOUS_NAMESPACE_BEGIN namespace {
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define ANONYMOUS_NAMESPACE_END }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define USING_NAMESPACE(x) using namespace x;
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DOCUMENTED_NAMESPACE_BEGIN(x) namespace x {
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DOCUMENTED_NAMESPACE_END }
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SW64LIT(x) x##i64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define W64LIT(x) x##ui64
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SW64LIT(x) x##L
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define W64LIT(x) x##UL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define SW64LIT(x) x##LL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define W64LIT(x) x##ULL
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CRYPTOPP_GCC_VERSION (__GNUC__ * 10000 + __GNUC_MINOR__ * 100 + __GNUC_PATCHLEVEL__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CRYPTOPP_XLC_VERSION ((__xlC__ / 256) * 10000 + (__xlC__ % 256) * 100)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CRYPTOPP_APPLE_CLANG_VERSION (__clang_major__ * 10000 + __clang_minor__ * 100 + __clang_patchlevel__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CRYPTOPP_LLVM_CLANG_VERSION (__clang_major__ * 10000 + __clang_minor__ * 100 + __clang_patchlevel__)
//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define CRYPTOPP_MSC_VERSION (_MSC_VER)
//# Laniatus Games Studio Inc. | WARN: Statement interrupted by a preprocessor statement:
//The original statement from the file config.h starts with:
//    NAMESPACE_END
//Statements interrupted by the preprocessor cannot be processed by this intent.//MyInfo
//The remainder of the header file config.h is ignored.

//# Laniatus Games Studio Inc. |: The following #define macro was replaced in-line:
//Original Metin2 CPlus Line: #define DEFAULT_VALUE_ALWAYS_SHOW_NAME true

