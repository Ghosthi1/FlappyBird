// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

// IWYU pragma: private, include "Flappy.h"
#include "UObject/ObjectMacros.h"
#include "UObject/ScriptMacros.h"

PRAGMA_DISABLE_DEPRECATION_WARNINGS
#ifdef FLAPPY4_Flappy_generated_h
#error "Flappy.generated.h already included, missing '#pragma once' in Flappy.h"
#endif
#define FLAPPY4_Flappy_generated_h

#define FID_Flappy4_Source_Flappy4_Flappy_h_12_INCLASS_NO_PURE_DECLS \
private: \
	static void StaticRegisterNativesAFlappy(); \
	friend struct Z_Construct_UClass_AFlappy_Statics; \
public: \
	DECLARE_CLASS(AFlappy, ACharacter, COMPILED_IN_FLAGS(0 | CLASS_Config), CASTCLASS_None, TEXT("/Script/Flappy4"), NO_API) \
	DECLARE_SERIALIZER(AFlappy)


#define FID_Flappy4_Source_Flappy4_Flappy_h_12_ENHANCED_CONSTRUCTORS \
private: \
	/** Private move- and copy-constructors, should never be used */ \
	AFlappy(AFlappy&&); \
	AFlappy(const AFlappy&); \
public: \
	DECLARE_VTABLE_PTR_HELPER_CTOR(NO_API, AFlappy); \
	DEFINE_VTABLE_PTR_HELPER_CTOR_CALLER(AFlappy); \
	DEFINE_DEFAULT_CONSTRUCTOR_CALL(AFlappy) \
	NO_API virtual ~AFlappy();


#define FID_Flappy4_Source_Flappy4_Flappy_h_9_PROLOG
#define FID_Flappy4_Source_Flappy4_Flappy_h_12_GENERATED_BODY \
PRAGMA_DISABLE_DEPRECATION_WARNINGS \
public: \
	FID_Flappy4_Source_Flappy4_Flappy_h_12_INCLASS_NO_PURE_DECLS \
	FID_Flappy4_Source_Flappy4_Flappy_h_12_ENHANCED_CONSTRUCTORS \
private: \
PRAGMA_ENABLE_DEPRECATION_WARNINGS


template<> FLAPPY4_API UClass* StaticClass<class AFlappy>();

#undef CURRENT_FILE_ID
#define CURRENT_FILE_ID FID_Flappy4_Source_Flappy4_Flappy_h


PRAGMA_ENABLE_DEPRECATION_WARNINGS
