# API Reference

This document provides a reference for all public classes, structs, properties, functions, and events exposed by the **SimpleLeveling** plugin.

## **Modules**

* **SimpleLeveling**: Runtime module containing core leveling logic.
* **SimpleLevelingEditor**: Editor module containing editor UI and logic.
* **SimpleLevelingTests**: Editor module containing unit test suite for **SimpleLeveling**.

## **Classes**

### **USimpleLevelingTrack**

Represents an individual leveling track. Contains the core logic to track levels and apply XP.

#### Events

* `FOnLevelingTrackChangeDelegate OnChangeEvent` – Broadcast when the leveling track changes.

#### Properties

* `FName LevelingTrackID`
* `FText LevelingTrackName`
* `FText LevelingTrackDescription`
* `int32 DefaultLevel`
* `int32 MinLevel`
* `int32 MaxLevel`
* `ESimpleLevelingTrackXPOverflowPolicy OverflowPolicy`
* `int32 BaseXPRequired`
* `UCurveFloat* XPCurve`
* `int32 CurrentLevel`
* `int32 CurrentXP`

#### Public Functions

* `int32 GetTotalXPRequiredForNextLevel() const`
* `int32 GetRemainingXPRequiredForNextLevel() const`
* `float GetXPPercentage() const`
* `void SetXP(int32 InNewXPValue, bool bBroadcastEvent = true)`
* `void AddXP(int32 InXPAmount, bool bBroadcastEvent = true)`
* `void SetLevel(int32 InNewLevelValue, bool bBroadcastEvent = true)`
* `void ResetXP(bool bBroadcastEvent = true)`
* `void ResetLevelingTrack(bool bBroadcastEvent = true)`
* `FSimpleLevelingTrackStorage GetStorage() const`
* `void InflateFromStorage(FSimpleLevelingTrackStorage Storage)`
* `void InflateFromDefinition(FSimpleLevelingTrackDefinition Definition)`

### **USimpleLevelingTrackComponent**

An `ActorComponent` wrapper for managing a single leveling track.

#### Events

* `FOnLevelingTrackChangeDelegate OnChangeEvent`

#### Properties

* `FSimpleLevelingTrackDefinition LevelingTrackDefinition`

#### Public Functions

* `USimpleLevelingTrack* GetLevelingTrack() const`
* `int32 GetLevel() const`
* `int32 GetXP() const`
* `int32 GetTotalXPRequiredForNextLevel() const`
* `int32 GetRemainingXPRequiredForNextLevel() const`
* `float GetXPPercentage() const`
* `void SetXP(int32 InNewXPValue, bool bBroadcastEvent = true)`
* `void AddXP(int32 InXPAmount, bool bBroadcastEvent = true)`
* `void SetLevel(int32 InNewLevelValue, bool bBroadcastEvent = true)`
* `void ResetXP(bool bBroadcastEvent = true)`
* `void ResetLevelingTrack(bool bBroadcastEvent = true)`
* `FSimpleLevelingTrackStorage GetStorage() const`
* `void InflateFromStorage(FSimpleLevelingTrackStorage Storage)`

### **USimpleLevelingSubsystem**

Global subsystem for managing multiple leveling tracks.

#### Events

* `FOnLevelingTrackChangeDelegate OnChangeEvent`

#### Properties

* `TMap<FName, USimpleLevelingTrack*> LevelingTracks`

#### Public Functions

* `TArray<USimpleLevelingTrack*> GetLevelingTracks() const`
* `USimpleLevelingTrack* GetLevelingTrack(FName InLevelingTrackID) const`
* `int32 GetLevel(FName InLevelingTrackID) const`
* `int32 GetXP(FName InLevelingTrackID) const`
* `int32 GetTotalXPRequiredForNextLevel(FName InLevelingTrackID) const`
* `int32 GetRemainingXPRequiredForNextLevel(FName InLevelingTrackID) const`
* `float GetXPPercentage(FName InLevelingTrackID) const`
* `void SetXP(FName InLevelingTrackID, int32 InNewXPValue, bool bBroadcastEvent = true)`
* `void AddXP(FName InLevelingTrackID, int32 InXPAmount, bool bBroadcastEvent = true)`
* `void SetLevel(FName InLevelingTrackID, int32 InNewLevelValue, bool bBroadcastEvent = true)`
* `void ResetXP(FName InLevelingTrackID, bool bBroadcastEvent = true)`
* `void ResetLevelingTrack(FName InLevelingTrackID, bool bBroadcastEvent = true)`
* `FSimpleLevelingSubsystemStorage GetStorage() const`
* `void InflateFromStorage(FSimpleLevelingSubsystemStorage Storage)`
* `void RegisterSubsystemDefinition(USimpleLevelingSubsystemDefinition* Definition)`

### **USimpleLevelingTrackChange**

Represents a single change event on a leveling track.

#### Properties

* `FName LevelingTrackID`
* `ESimpleLevelingTrackChangeType Type`
* `int32 LevelChange`
* `int32 XPChange`

#### Public Functions

* `void GetValues(FName& OutLevelingTrackID, ESimpleLevelingTrackChangeType& OutType, int32& OutLevelChange, int32& OutXPChange) const`

### **FSimpleLevelingXPCalculator**

Utility class for XP calculations.

#### Public Functions

* `TArray<int32> CalculateXPTable(int32 BaseXPRequired, int32 MinLevel, int32 MaxLevel, UCurveFloat* XPCurve)`
* `int32 CalculateTotalXPRequiredForNextLevel(int32 BaseXPRequired, int32 CurrentLevel, int32 MinLevel, int32 MaxLevel, UCurveFloat* XPCurve)`

## **Enums**

### `ESimpleLevelingTrackChangeType`

Defines the type of change event fired when a leveling track changes.

* `XPChanged`
* `LevelChanged`
* `ReachedMaxLevel`
* `Reset`

### `ESimpleLevelingTrackXPOverflowPolicy`

Defines the behavior when excess XP is applied during level up.

* `CarryOver` – Excess XP carries over to the next level.
* `Discard` – Excess XP is discarded when leveling up.

## **Structs**

### `FSimpleLevelingTrackDefinition`

Used to define a single leveling track in a data asset or component.

* `FName LevelingTrackID`
* `FText LevelingTrackName`
* `FText LevelingTrackDescription`
* `int32 DefaultLevel`
* `int32 MinLevel`
* `int32 MaxLevel`
* `ESimpleLevelingTrackXPOverflowPolicy OverflowPolicy`
* `int32 BaseXPRequired`
* `UCurveFloat* XPCurve`

### `FSimpleLevelingTrackStorage`

Represents a snapshot of a single leveling track's state.

* `FName LevelingTrackID`
* `FText LevelingTrackName`
* `FText LevelingTrackDescription`
* `int32 DefaultLevel`
* `int32 MinLevel`
* `int32 MaxLevel`
* `ESimpleLevelingTrackXPOverflowPolicy OverflowPolicy`
* `int32 BaseXPRequired`
* `UCurveFloat* XPCurve`
* `int32 CurrentLevel`
* `int32 CurrentXP`
* `bool bHasBroadcastMaxLevelReachedEvent`

### `FSimpleLevelingSubsystemStorage`

Represents the entire leveling system's state for persistence including all leveling tracks.

* `TArray<FSimpleLevelingTrackStorage> StoredTracks`

## **Data Assets**

### **USimpleLevelingSubsystemDefinition**

Defines a collection of leveling track definitions for subsystem registration.

#### Properties

* `TArray<FSimpleLevelingTrackDefinition> LevelingTrackDefinitions`
