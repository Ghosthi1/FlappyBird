// Copyright Epic Games, Inc. All Rights Reserved.
/*===========================================================================
	Generated code exported from UnrealHeaderTool.
	DO NOT modify this manually! Edit the corresponding .h files instead!
===========================================================================*/

#include "UObject/GeneratedCppIncludes.h"
#include "Flappy4/PlayerPawn.h"
PRAGMA_DISABLE_DEPRECATION_WARNINGS
void EmptyLinkFunctionForGeneratedCodePlayerPawn() {}

// Begin Cross Module References
ENGINE_API UClass* Z_Construct_UClass_APawn();
FLAPPY4_API UClass* Z_Construct_UClass_APlayerPawn();
FLAPPY4_API UClass* Z_Construct_UClass_APlayerPawn_NoRegister();
UPackage* Z_Construct_UPackage__Script_Flappy4();
// End Cross Module References

// Begin Class APlayerPawn
void APlayerPawn::StaticRegisterNativesAPlayerPawn()
{
}
IMPLEMENT_CLASS_NO_AUTO_REGISTRATION(APlayerPawn);
UClass* Z_Construct_UClass_APlayerPawn_NoRegister()
{
	return APlayerPawn::StaticClass();
}
struct Z_Construct_UClass_APlayerPawn_Statics
{
#if WITH_METADATA
	static constexpr UECodeGen_Private::FMetaDataPairParam Class_MetaDataParams[] = {
		{ "HideCategories", "Navigation" },
		{ "IncludePath", "PlayerPawn.h" },
		{ "ModuleRelativePath", "PlayerPawn.h" },
	};
#endif // WITH_METADATA
	static UObject* (*const DependentSingletons[])();
	static constexpr FCppClassTypeInfoStatic StaticCppClassTypeInfo = {
		TCppClassTypeTraits<APlayerPawn>::IsAbstract,
	};
	static const UECodeGen_Private::FClassParams ClassParams;
};
UObject* (*const Z_Construct_UClass_APlayerPawn_Statics::DependentSingletons[])() = {
	(UObject* (*)())Z_Construct_UClass_APawn,
	(UObject* (*)())Z_Construct_UPackage__Script_Flappy4,
};
static_assert(UE_ARRAY_COUNT(Z_Construct_UClass_APlayerPawn_Statics::DependentSingletons) < 16);
const UECodeGen_Private::FClassParams Z_Construct_UClass_APlayerPawn_Statics::ClassParams = {
	&APlayerPawn::StaticClass,
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
	METADATA_PARAMS(UE_ARRAY_COUNT(Z_Construct_UClass_APlayerPawn_Statics::Class_MetaDataParams), Z_Construct_UClass_APlayerPawn_Statics::Class_MetaDataParams)
};
UClass* Z_Construct_UClass_APlayerPawn()
{
	if (!Z_Registration_Info_UClass_APlayerPawn.OuterSingleton)
	{
		UECodeGen_Private::ConstructUClass(Z_Registration_Info_UClass_APlayerPawn.OuterSingleton, Z_Construct_UClass_APlayerPawn_Statics::ClassParams);
	}
	return Z_Registration_Info_UClass_APlayerPawn.OuterSingleton;
}
template<> FLAPPY4_API UClass* StaticClass<APlayerPawn>()
{
	return APlayerPawn::StaticClass();
}
DEFINE_VTABLE_PTR_HELPER_CTOR(APlayerPawn);
APlayerPawn::~APlayerPawn() {}
// End Class APlayerPawn

// Begin Registration
struct Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_PlayerPawn_h_Statics
{
	static constexpr FClassRegisterCompiledInInfo ClassInfo[] = {
		{ Z_Construct_UClass_APlayerPawn, APlayerPawn::StaticClass, TEXT("APlayerPawn"), &Z_Registration_Info_UClass_APlayerPawn, CONSTRUCT_RELOAD_VERSION_INFO(FClassReloadVersionInfo, sizeof(APlayerPawn), 3346382223U) },
	};
};
static FRegisterCompiledInInfo Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_PlayerPawn_h_621891464(TEXT("/Script/Flappy4"),
	Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_PlayerPawn_h_Statics::ClassInfo, UE_ARRAY_COUNT(Z_CompiledInDeferFile_FID_Flappy4_Source_Flappy4_PlayerPawn_h_Statics::ClassInfo),
	nullptr, 0,
	nullptr, 0);
// End Registration
PRAGMA_ENABLE_DEPRECATION_WARNINGS
