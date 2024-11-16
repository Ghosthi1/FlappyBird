// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "Flappy4/Flappy.h"
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodeFlappy() {}

// Begin Cross Module References
ENGINE_API UClass* Z_Construct_UClass_ACharacter();
FLAPPY4_API UClass* Z_Construct_UClass_AFlappy();
FLAPPY4_API UClass* Z_Construct_UClass_AFlappy_NoRegister();
UPackage* Z_Construct_UPackage__Script_Flappy4();
// End Cross Module References

// Begin Class AFlappy
void AFlappy::StaticRegisterNativesAFlappy()
{
}
IMPLEMENT_CLASS_NO_AUTO_REGISTRATION(AFlappy);
UClass* Z_Construct_UClass_AFlappy_NoRegister()
{
	return AFlappy::StaticClass();
}
struct Z_Construct_UClass_AFlappy_Statics
{
#if WITH_METADATA
	static constexpr UECodeGen_Private::FMetaDataPairParam Class_MetaDataParams[] = {
		{ "HideCategories", "Navigation" },
		{ "IncludePath", "Flappy.h" },
		{ "ModuleRelativePath", "Flappy.h" },
	};
#endif // WITH_METADATA
	static UObject* (*const DependentSingletons[])();
	static constexpr FCppClassTypeInfoStatic StaticCppClassTypeInfo = {
		TCppClassTypeTraits<AFlappy>::IsAbstract,
	};
	static const UECodeGen_Private::FClassParams ClassParams;
};
UObject* (*const Z_Construct_UClass_AFlappy_Statics::DependentSingletons[])() = {
	(UObject* (*)())Z_Construct_UClass_ACharacter,
	(UObject* (*)())Z_Construct_UPackage__Script_Flappy4,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UClass_AFlappy_Statics::DependentSingletons) < 16);
const UECodeGen_Private::FClassParams Z_Construct_UClass_AFlappy_Statics::ClassParams = {
	&AFlappy::StaticClass,
	"Game",
	&StaticCppClassTypeInfo,
	DependentSingletons,
	nullptr,
	nullptr,
	nullptr,
	UE_ARRAY_COUNT(DependentSingletons),
	0,
	0,
	0,
	0x009000A4u,
	METADATA_PARAMS(UE_ARRAY_COUNT(Z_Construct_UClass_AFlappy_Statics::Class_MetaDataParams), Z_Construct_UClass_AFlappy_Statics::Class_MetaDataParams)
};
UClass* Z_Construct_UClass_AFlappy()
{
	if (!Z_Registration_Info_UClass_AFlappy.OuterSingleton)
	{
		UECodeGen_Private::ConstructUClass(Z_Registration_Info_UClass_AFlappy.OuterSingleton, Z_Construct_UClass_AFlappy_Statics::ClassParams);
	}
	return Z_Registration_Info_UClass_AFlappy.OuterSingleton;
}
template<> FLAPPY4_API UClass* StaticClass<AFlappy>()
{
	return AFlappy::StaticClass();
}
DEFINE_VTABLE_PTR_HELPER_CTOR(AFlappy);
AFlappy::~AFlappy() {}
// End Class AFlappy

// Begin Registration
struct Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_Flappy_h_Statics
{
	static constexpr FClassRegisterCompiledInInfo ClassInfo[] = {
		{ Z_Construct_UClass_AFlappy, AFlappy::StaticClass, TEXT("AFlappy"), &Z_Registration_Info_UClass_AFlappy, CONSTRUCT_RELOAD_VERSION_INFO(FClassReloadVersionInfo, sizeof(AFlappy), 2805219582U) },
	};
};
static FRegisterCompiledInInfo Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_Flappy_h_1430388598(TEXT("/Script/Flappy4"),
	Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_Flappy_h_Statics::ClassInfo, UE_ARRAY_COUNT(Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_Flappy_h_Statics::ClassInfo),
	nullptr, 0,
	nullptr, 0);
// End Registration
PRAGMA_ENABLE_DEPRECATION_WARNINGS
