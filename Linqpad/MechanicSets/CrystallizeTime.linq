<Query Kind="Statements">
  <Reference>E:\Downloads\xiv\xivsim\XivMechanicSimNetworked_Data\Managed\Assembly-CSharp.dll</Reference>
  <Reference>E:\Downloads\xiv\xivsim\XivMechanicSimNetworked_Data\Managed\UnityEngine.CoreModule.dll</Reference>
  <Namespace>UnityEngine</Namespace>
</Query>

var mechanicName = "CrystallizeTimeDemo";
var baseOutputPath = @"E:\Downloads\xiv\xivsim\";
var buildOutputPath = @"E:\Downloads\xiv\xivsim\Build";

var mechanicData = new MechanicData();

float ScaleToSim(float gameScale)
{
	return gameScale / 3f;
}

Vector3[] lights = new Vector3[6];
for (int i = 0; i < 6; i++)
{
	float a = 2 * Mathf.PI / 6 * i;
	float x = 3.8f * Mathf.Cos(3 * Mathf.PI / 2 - a);
	float z = 3.8f * Mathf.Sin(3 * Mathf.PI / 2 - a);
	lights[i] = new Vector3(x, 1f, z);
}

Vector3[] edgeMarkers = new Vector3[8];
for (int i = 0; i < 8; i++)
{
	float a = 2 * Mathf.PI / 8 * i;
	float x = 7f * Mathf.Cos(3 * Mathf.PI / 2 - a);
	float z = 7f * Mathf.Sin(3 * Mathf.PI / 2 - a);
	edgeMarkers[i] = new Vector3(x, 0.2f, z);
}

Vector3 lightScale = new Vector3(0.7f, 1, 1);

mechanicData.referenceMechanicProperties = new Dictionary<string, MechanicProperties>
{
	{
		"GlobalMechanics",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "SpawnTrafficLights" },
					new SpawnMechanicEvent { referenceMechanicName = "SpawnEdgeMarkers" },
					new SpawnMechanicEvent { referenceMechanicName = "SpawnGaia" },
					new SpawnMechanicEvent { referenceMechanicName = "SpawnCrystal", position = new Vector2 (0, 6.6f) },
					new WaitEvent { timeToWait = 4 },
					new SpawnMechanicEvent { referenceMechanicName = "Raidwide" },
					new SpawnMechanicEvent { referenceMechanicName = "ApplyDebuffs" },
					new WaitEvent { timeToWait = 3.6f },
					new ExecuteRandomEvents { mechanicPoolName = "TrafficPool"},
					new SpawnMechanicEvent { referenceMechanicName = "SpawnDragonHeads"},
					new SpawnMechanicEvent { referenceMechanicName = "NSTraffic"},
					new WaitEvent { timeToWait = 13.4f },
					new ExecuteRandomEvents { mechanicPoolName = "EWExaPool"},
					new WaitEvent { timeToWait = 6.4f },
					new ExecuteRandomEvents { mechanicPoolName = "NSExaPool"},
					new WaitEvent {timeToWait = float.PositiveInfinity },
				}
			}
		}
	},
	{
		"SpawnTrafficLights",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/TrafficLight.png", colorHtml = "#80ff80", visualDuration = float.PositiveInfinity, scale = lightScale, eulerAngles = new Vector3(0, 180, 0), relativePosition = lights[0], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/TrafficLight.png", colorHtml = "#80ff80", visualDuration = float.PositiveInfinity, scale = lightScale, eulerAngles = new Vector3(0, 180, 0), relativePosition = lights[1], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/TrafficLight.png", colorHtml = "#80ff80", visualDuration = float.PositiveInfinity, scale = lightScale, eulerAngles = new Vector3(0, 180, 0), relativePosition = lights[2], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/TrafficLight.png", colorHtml = "#80ff80", visualDuration = float.PositiveInfinity, scale = lightScale, eulerAngles = new Vector3(0, 180, 0), relativePosition = lights[3], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/TrafficLight.png", colorHtml = "#80ff80", visualDuration = float.PositiveInfinity, scale = lightScale, eulerAngles = new Vector3(0, 180, 0), relativePosition = lights[4], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/TrafficLight.png", colorHtml = "#80ff80", visualDuration = float.PositiveInfinity, scale = lightScale, eulerAngles = new Vector3(0, 180, 0), relativePosition = lights[5], isBillboard = true },
				}
			}
		}
	},
	{
		"SpawnEdgeMarkers",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[0], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[1], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[2], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[3], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[4], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[5], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[6], isBillboard = true },
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/EdgeMarker.png", colorHtml = "#cccccc", visualDuration = float.PositiveInfinity, scale = Vector3.one * 0.33f, eulerAngles = new Vector3(0, 180, 0), relativePosition = edgeMarkers[7], isBillboard = true },
				}
			}
		}
	},
	{
		"SpawnCrystal",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(3), 360),
			colorHtml = "#90ff10",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject {textureFilePath = "Mechanics/Resources/FruCrystal.png", colorHtml = "#70ff00", visualDuration = float.PositiveInfinity, scale = Vector3.one * 1.3f, relativePosition = new Vector3(0, 1, 0), eulerAngles = new Vector3(0, 180, 0), isBillboard = true},
					new WaitEvent { timeToWait = 9.6f },
					new SpawnMechanicEvent { referenceMechanicName = "CrystalRaidwide" },
					new WaitEvent { timeToWait = 30.4f },
					new SpawnMechanicEvent { referenceMechanicName = "CheckCrystalProximity", isPositionRelative = true },
					new WaitEvent { timeToWait = float.PositiveInfinity },
				}
			},
			persistentTickInterval = 99,
			persistentActivationDelay = 999,
			persistentMechanic = new WaitEvent { timeToWait = float.PositiveInfinity },
		}
	},
	{
		"CheckCrystalProximity",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(8), 360),
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ApplyEffectToPlayers { effect = new DamageEffect { damageAmount = 0, damageType = "Damage", name = "Too close to the crystal!" } },
				}
			}
		}
	},
	{
		"ApplyDebuffs",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ReshufflePlayerIds{},
					new SpawnTargetedEvents { referenceMechanicName = "ApplyReturn", targetingScheme = new TargetAllPlayers() },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyWyrmclawShort", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 2, 6 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyWyrmclaw", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 0, 4 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyWyrmfang", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 1, 3, 5, 7 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyAero", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 0, 4 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyIce", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 2, 5, 6 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyStack", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 7 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplySpread", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 3 } } },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyWater", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 1 } } },
					new ReshufflePlayerIds{},
					new SpawnTargetedEvents { referenceMechanicName = "ApplyQuietus", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 0, 1, 2 } } },
				}
			}
		}
	},
	{
		"ApplyAero",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "AeroWaiting" }
			}
		}
	},
	{
		"ApplyIce",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "IceWaiting" }
			}
		}
	},
	{
		"ApplyStack",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "StackWaiting" }
			}
		}
	},
	{
		"ApplySpread",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "SpreadWaiting" }
			}
		}
	},
	{
		"ApplyWater",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "WaterWaiting" }
			}
		}
	},
	{
		"ApplyWyrmfang",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "Wyrmfang" }
			}
		}
	},
	{
		"ApplyWyrmclaw",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "Wyrmclaw" }
			}
		}
	},
	{
		"ApplyWyrmclawShort",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "Wyrmclaw", overrideDuration = 17 }
			}
		}
	},
	{
		"ApplyReturn",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "ReturnWaiting" }
			}
		}
	},
	{
		"ApplyQuietus",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "QuietusWaiting" }
			}
		}
	},
	{
		"GaiaMechanics",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 1 },
					new StartCastBar { castName = "Crystallize Time", duration = 3 },
					new WaitEvent { timeToWait = 6 },
					new StartCastBar { castName = "Speed", duration = 5 },
					new WaitEvent { timeToWait = 30.2f },
					new StartCastBar { castName = "Spirit Taker", duration = 2.7f },
					new WaitEvent { timeToWait = 3 },
					new ReshufflePlayerIds{},
					new SpawnTargetedEvents { referenceMechanicName = "GaiaJump", spawnOnTarget = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> { 0 } } },
					new SetEnemyMovement { moveToTarget = new TargetSpecificPlayerIds { targetIds = new List<int> { 0 } }, movementTime = 0.1f },
					new WaitEvent { timeToWait = 2 },
					new SetEnemyVisible { visible = false },
					new WaitEvent { timeToWait = float.PositiveInfinity },
				}
			}
		}
	},
	{
		"GaiaJump",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(5), 360),
			colorHtml = "#0f0f0f",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ApplyEffectToPlayers 
					{ 
						effects = new List<MechanicEffect> 
						{
							new DamageEffect { damageAmount = 30000, damageType = "Physical", name = "Spirit Taker" },
						}
					},
					new WaitEvent { timeToWait = 0.1f },
					new ApplyEffectToPlayers 
					{
						condition = new CheckPlayerIsMechanicTarget(),
						effects = new List<MechanicEffect> {},
						failedConditionEffects = new List<MechanicEffect>
						{
							new KnockbackEffect { knockbackDistance = 20 } 
						}
					},
					new WaitEvent { timeToWait = 0.1f },
				}
			}
		}
	},
	{
		"ReturnSequence",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(0.0001f, 360),
			colorHtml = "#9b66ff",
			isTargeted = true,
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnTargetedEvents { referenceMechanicName = "ReturnPuddle", spawnOnTarget = true, targetingScheme = new TargetExistingTarget{} },
					new ApplyEffectToTargetOnly { effect = new ApplyStatusEffect { referenceStatusName = "ReturnPending" } },
					new WaitEvent { timeToWait = 7.5f },
					new SpawnTargetedEvents { referenceMechanicName = "ReturnKBHelper", spawnOnTarget = true, targetingScheme = new TargetExistingTarget{} },
					new WaitEvent { timeToWait = 1f },
					new ApplyEffectToTargetOnly { effect = new KnockbackEffect { knockbackDistance = 999, isDrawIn = true, canArmsLength = false, additionalKnockbackSpeed = 5 } }
				}
			}
		}
	},
	{
		"ReturnPuddle",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(0.5f, 360),
			colorHtml = "#9b66ff",
			mechanic = new WaitEvent { timeToWait = 8.5f },
		}
	},
	{
		"ReturnKBHelper",
		new MechanicProperties
		{
			isTargeted = true,
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 1.5f },
					new ApplyEffectToTargetOnly { effect = new KnockbackEffect { knockbackDistance = 0.615f, canArmsLength = false } }
				}
			}
		}
	},
	{
		"ReturnStun",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "Stun" }
			}
		}
	},
	{
		"SpawnDragonHeads",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEventsParallel
			{
				events = new List<MechanicEvent>
				{
					new SpawnEnemy {
						enemyName = "Drachen Wanderer",
						textureFilePath = "Mechanics/Resources/DragonHead.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						hitboxSize = 1,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = Vector3.one * 1.25f,
						referenceMechanicName = "DragonHead1AMove",
						position = new Vector2(-0.6f, 4.5f),
						isTargetable = false,
						showInEnemyList = false,
					},
					new SpawnEnemy {
						enemyName = "Drachen Wanderer",
						textureFilePath = "Mechanics/Resources/DragonHead.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						hitboxSize = 1,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = Vector3.one * 1.25f,
						rotation = 180,
						referenceMechanicName = "DragonHead2AMove",
						position = new Vector2(0.6f, 4.5f),
						isTargetable = false,
						showInEnemyList = false,
					},
					new SpawnEnemy {
						enemyName = "Drachen Wanderer",
						textureFilePath = "Mechanics/Resources/DragonHead.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						hitboxSize = 1,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = Vector3.one * 0.75f,
						referenceMechanicName = "DragonHead1BMove",
						position = new Vector2(-0.6f, 4.5f),
						isVisible = false,
						isTargetable = false,
						showInEnemyList = false,
					},
					new SpawnEnemy {
						enemyName = "Drachen Wanderer",
						textureFilePath = "Mechanics/Resources/DragonHead.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						hitboxSize = 1,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = Vector3.one * 0.75f,
						rotation = 180,
						referenceMechanicName = "DragonHead2BMove",
						position = new Vector2(0.6f, 4.5f),
						isVisible = false,
						isTargetable = false,
						showInEnemyList = false,
					},
				}
			}
		}
	},
	{
		"DragonHead1AMove",
		new MechanicProperties
		{
			visible = false,
			mechanicTag = "DragonHead1A",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 5 },
					new SetEnemyMovementPath { path = new CircleMovementPath { radius = 4.6f, degreesPerSecond = 14, startAngle = 100 } },
					new SpawnTethersToPlayers { referenceTetherName = "DragonHead1ADistance", targetingScheme = new TargetAllPlayers() },
					new WaitEvent { timeToWait = 25 },
				}
			}
		}
	},
	{
		"DragonHead2AMove",
		new MechanicProperties
		{
			visible = false,
			mechanicTag = "DragonHead2A",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 5 },
					new SetEnemyMovementPath { path = new CircleMovementPath { radius = 4.6f, degreesPerSecond = -14, startAngle = 80 } },
					new SpawnTethersToPlayers { referenceTetherName = "DragonHead2ADistance", targetingScheme = new TargetAllPlayers() },
					new WaitEvent { timeToWait = 25 },
				}
			}
		}
	},
	{
		"DragonHead1BMove",
		new MechanicProperties
		{
			visible = false,
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			mechanicTag = "DragonHead1B",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 5 },
					new SetEnemyMovementPath { path = new CircleMovementPath { radius = 4.6f, degreesPerSecond = 14, startAngle = 100 } },
					new SpawnTethersToPlayers { referenceTetherName = "DragonHead1BDistance", targetingScheme = new TargetAllPlayers() },
					new WaitEvent { timeToWait = 25 },
					new SpawnMechanicEvent { referenceMechanicName = "DragonHeadEnrage", isPositionRelative = true },
					new WaitEvent { timeToWait = 0.1f },
					new EndMechanic{}
				}
			},
			persistentTickInterval = 0.5f,
			persistentActivationDelay = 5,
			persistentMechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new PausePersistentEvent { duration = 60 },
					new WaitForGlobalInt { variableName = "pop1", value = 1 },
					new SpawnTethersToPlayers { referenceTetherName = "DragonHead1CDistance", targetingScheme = new TargetAllPlayers() },
					new WaitEvent { timeToWait = 30 },
					new EndMechanic{},
				}
			}
		}
	},
	{
		"DragonHead2BMove",
		new MechanicProperties
		{
			visible = false,
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			mechanicTag = "DragonHead2B",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 5 },
					new SetEnemyMovementPath { path = new CircleMovementPath { radius = 4.6f, degreesPerSecond = -14, startAngle = 80 } },
					new SpawnTethersToPlayers { referenceTetherName = "DragonHead2BDistance", targetingScheme = new TargetAllPlayers() },
					new WaitEvent { timeToWait = 25 },
					new SpawnMechanicEvent { referenceMechanicName = "DragonHeadEnrage", isPositionRelative = true },
					new WaitEvent { timeToWait = 0.1f },
					new EndMechanic{}
				}
			},
			persistentTickInterval = 0.2f,
			persistentActivationDelay = 5,
			persistentMechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new PausePersistentEvent { duration = 60 },
					new WaitForGlobalInt { variableName = "pop2", value = 1 },
					new SpawnTethersToPlayers { referenceTetherName = "DragonHead2CDistance", targetingScheme = new TargetAllPlayers() },
					new WaitEvent { timeToWait = 30 },
					new EndMechanic{},
				}
			}
		}
	},
	{
		"DragonHead1BActivate",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SetEnemyVisible { visible = true },
					new SetGlobalInt { variableName = "pop1", value = 1 },
				}
			}
		}
	},
	{
		"DragonHead2BActivate",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SetEnemyVisible { visible = true },
					new SetGlobalInt { variableName = "pop2", value = 1 },
				}
			}
		}
	},
	{
		"DragonHeadExplode",
		new MechanicProperties
		{
			visible = false,
			isTargeted = true,
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(12), 360),
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ApplyEffectToPlayers 
					{
						condition = new CheckMultipleConditions 
						{
							requireAll = true,
							conditions = new List<Condition>
							{
								new CheckPlayerStatus { statusName = "Wyrmclaw" },
								new CheckPlayerIsMechanicTarget{},
							}
						},
						effects = new List<MechanicEffect> 
						{
							new DamageEffect { damageAmount = 50000, damageType = "Magic", name = "Longing of the Lost" },
							new RemoveStatusEffect { referenceStatusName = "Wyrmclaw" }
						},
						failedConditionEffects = new List<MechanicEffect>
						{ 
							new DamageEffect { damageAmount = 999999, damageType = "Damage", name = "Longing of the Lost" },
						}
					},
				}
			}
		}
	},
	{
		"DragonExplodeHelper1",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(12), 360),
			colorHtml = "#ffffff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnTargetedEvents { referenceMechanicName = "DragonHeadExplode", isPositionRelative = true, targetingScheme = new TargetSpecificProximityPlayers { targetIds = new List<int> { 0 } } },
					new SpawnMechanicEvent { referenceMechanicName = "DragonPuddle", isPositionRelative = true },
					new WaitEvent { timeToWait = 0.2f },
				}
			}
		}
	},
	{
		"DragonExplodeHelper2",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(12), 360),
			colorHtml = "#ffffff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnTargetedEvents { referenceMechanicName = "DragonHeadExplode", isPositionRelative = true, targetingScheme = new TargetSpecificProximityPlayers { targetIds = new List<int> { 0 } } },
					new SpawnMechanicEvent { referenceMechanicName = "DragonPuddle", isPositionRelative = true },
					new WaitEvent { timeToWait = 0.2f },
				}
			}
		}
	},
	{
		"DragonPuddle",
		new MechanicProperties
		{
			visible = true,
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(0.4f, 360),
			colorHtml = "#ffffff",
			mechanic = new WaitEvent { timeToWait = 16f },
			persistentTickInterval = 0.3f,
			persistentActivationDelay = 2,
			persistentMechanic = new CheckNumberOfPlayers
			{
				expressionFormat = "{0} = 0",
				failEvent = new ExecuteMultipleEvents
				{
					events = new List<MechanicEvent>
					{
						new ApplyEffectToPlayers { effect = new RemoveStatusEffect { referenceStatusName = "Wyrmfang" } },
						new EndMechanic{},
					}
				}
			}
		}
	},
	{
		"DragonHeadEnrage",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			visible = false,
			mechanic = new ApplyEffectToPlayers
			{
				effect = new DamageEffect { damageAmount = 999999, damageType = "Damage", name = "Dragon Head Enrage" }
			}
		}
	},
	{
		"NSTraffic",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "TrafficLines" },
					new WaitEvent { timeToWait = 6 },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[0].x, lights[0].z) },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[3].x, lights[3].z) },
				}
			}
		}
	},
	{
		"NWTraffic",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "NWTrafficLines" },
					new WaitEvent { timeToWait = 11.5f },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[1].x, lights[1].z) },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[4].x, lights[4].z) },
					new WaitEvent { timeToWait = 5 },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[2].x, lights[2].z) },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[5].x, lights[5].z) },
				}
			}
		}
	},
	{
		"SWTraffic",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "SWTrafficLines" },
					new WaitEvent { timeToWait = 11.5f },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[2].x, lights[2].z) },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[5].x, lights[5].z) },
					new WaitEvent { timeToWait = 5 },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[1].x, lights[1].z) },
					new SpawnMechanicEvent { referenceMechanicName = "TrafficExplosion", position = new Vector2(lights[4].x, lights[4].z) },
				}
			}
		}
	},
	{
		"TrafficExplosion",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(12.6f), 360),
			colorHtml = "#FF4400",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 1 },
					new ApplyEffectToPlayers { effect = new DamageEffect { damageAmount = 300000, damageType = "Magic", name = "Maelstrom" } },
					new ApplyEffectToPlayers { effect = new ApplyStatusEffect { referenceStatusName = "DamageDown" } },
				}
			}
		}
	},
	{
		"Raidwide",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			visible = false,
			mechanic = new ApplyEffectToPlayers
			{
				effect = new DamageEffect { damageAmount = 80000, damageType = "Magic", name = "Crystallize Time" }
			}
		}
	},
	{
		"Quietus",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			visible = false,
			mechanic = new ApplyEffectToPlayers
			{
				effect = new DamageEffect { damageAmount = 25000, damageType = "Magic", name = "Quietus" }
			}
		}
	},
	{
		"CrystalRaidwide",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			visible = false,
			mechanic = new ApplyEffectToPlayers
			{
				effect = new DamageEffect { damageAmount = 25000, damageType = "Magic", name = "Edge of Oblivion" }
			}
		}
	},
	{
		"SpawnGaia",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnEnemy {
						enemyName = "Oracle of Darkness",
						textureFilePath = "Mechanics/Resources/Shiva.png",
						colorHtml = "#0f0f0f",
						maxHp = 35000000,
						baseMoveSpeed = 0,
						hitboxSize = 2,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = new Vector3(1, 2, 1) * 1.5f,
						referenceMechanicName = "GaiaMechanics",
						rotation = 180,
						isPositionRelative = true,
						isRotationRelative = true,
						isTargetable = false,
					},
				}
			}
		}
	},
	{
		"SpawnShivaN",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnEnemy {
						enemyName = "Heritor of Frost",
						textureFilePath = "Mechanics/Resources/Shiva.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						baseMoveSpeed = 0,
						hitboxSize = 2,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = new Vector3(1, 2, 1) * 1.5f,
						referenceMechanicName = "ShivaMechanicsN",
						rotation = 180,
						position = new Vector2(0, 7),
						isPositionRelative = true,
						isRotationRelative = true,
						isTargetable = false,
					},
				}
			}
		}
	},
	{
		"SpawnShivaS",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnEnemy {
						enemyName = "Heritor of Frost",
						textureFilePath = "Mechanics/Resources/Shiva.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						baseMoveSpeed = 0,
						hitboxSize = 2,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = new Vector3(1, 2, 1) * 1.5f,
						referenceMechanicName = "ShivaMechanicsS",
						rotation = 0,
						position = new Vector2(0, -7),
						isPositionRelative = true,
						isRotationRelative = true,
						isTargetable = false,
					},
				}
			}
		}
	},
	{
		"SpawnShivaE",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnEnemy {
						enemyName = "Heritor of Frost",
						textureFilePath = "Mechanics/Resources/Shiva.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						baseMoveSpeed = 0,
						hitboxSize = 2,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = new Vector3(1, 2, 1) * 1.5f,
						referenceMechanicName = "ShivaMechanicsE",
						rotation = 270,
						position = new Vector2(7, 0),
						isPositionRelative = true,
						isRotationRelative = true,
						isTargetable = false,
					},
				}
			}
		}
	},
	{
		"SpawnShivaW",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnEnemy {
						enemyName = "Heritor of Frost",
						textureFilePath = "Mechanics/Resources/Shiva.png",
						colorHtml = "#0047b1",
						maxHp = 35000000,
						baseMoveSpeed = 0,
						hitboxSize = 2,
						visualPosition = new Vector3(0, 1, 0),
						visualScale = new Vector3(1, 2, 1) * 1.5f,
						referenceMechanicName = "ShivaMechanicsW",
						rotation = 90,
						position = new Vector2(-7, 0),
						isPositionRelative = true,
						isRotationRelative = true,
						isTargetable = false,
					},
				}
			}
		}
	},
	{
		"ShivaMechanicsS",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.5f },
					new StartCastBar { castName = "Tidal Light", duration = 2.7f },
					new SpawnMechanicEvent { referenceMechanicName = "FirstExaline", rotation = 90, position = new Vector2(-7, -5.25f) },
					new WaitEvent { timeToWait = 2.8f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", rotation = 90, position = new Vector2(-7, -1.75f) },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", rotation = 90, position = new Vector2(-7, 1.75f) },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", rotation = 90, position = new Vector2(-7, 5.25f) },
					new WaitEvent { timeToWait = 4.8f },
					new StartCastBar { castName = "Hallowed Wings", duration = 4.4f },
					new WaitEvent { timeToWait = 4.4f },
					new SetEnemyVisible { visible = false },
					new WaitEvent { timeToWait = 6.5f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnMechanicEvent { referenceMechanicName = "HallowedWings", position = new Vector2(0, -7) },
					new WaitEvent { timeToWait = 1.5f },
					new SetEnemyVisible { visible = false },
				}
			}
		}
	},
	{
		"ShivaMechanicsN",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.5f },
					new StartCastBar { castName = "Tidal Light", duration = 2.7f },
					new SpawnMechanicEvent { referenceMechanicName = "FirstExaline", rotation = 90, position = new Vector2(-7, 5.25f) },
					new WaitEvent { timeToWait = 2.8f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", rotation = 90, position = new Vector2(-7, 1.75f) },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", rotation = 90, position = new Vector2(-7, -1.75f) },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", rotation = 90, position = new Vector2(-7, -5.25f) },
					new WaitEvent { timeToWait = 6.3f },
					new StartCastBar { castName = "Hallowed Wings", duration = 4.4f },
					new WaitEvent { timeToWait = 4.4f },
					new SetEnemyVisible { visible = false },
					new WaitEvent { timeToWait = 5.5f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnMechanicEvent { referenceMechanicName = "HallowedWings", rotation = 180, position = new Vector2(0, 7) },
					new WaitEvent { timeToWait = 1.5f },
					new SetEnemyVisible { visible = false },
				}
			}
		}
	},
	{
		"ShivaMechanicsE",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.5f },
					new StartCastBar { castName = "Tidal Light", duration = 2.7f },
					new SpawnMechanicEvent { referenceMechanicName = "FirstExaline", position = new Vector2(5.25f, -7) },
					new WaitEvent { timeToWait = 2.8f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", position = new Vector2(1.75f, -7) },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", position = new Vector2(-1.75f, -7) },
					new SetEnemyVisible { visible = false },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", position = new Vector2(-5.25f, -7) },
					new WaitEvent { timeToWait = 18.6f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnMechanicEvent { referenceMechanicName = "HallowedWings", rotation = 270, position = new Vector2(7, -0) },
					new WaitEvent { timeToWait = 1.5f },
					new SetEnemyVisible { visible = false },
				}
			}
		}
	},
	{
		"ShivaMechanicsW",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.5f },
					new StartCastBar { castName = "Tidal Light", duration = 2.7f },
					new SpawnMechanicEvent { referenceMechanicName = "FirstExaline", position = new Vector2(-5.25f, -7) },
					new WaitEvent { timeToWait = 2.8f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", position = new Vector2(-1.75f, -7) },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", position = new Vector2(1.75f, -7) },
					new SetEnemyVisible { visible = false },
					new WaitEvent { timeToWait = 1.9f },
					new SpawnMechanicEvent { referenceMechanicName = "Exaline", position = new Vector2(5.25f, -7) },
					new WaitEvent { timeToWait = 18.6f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnMechanicEvent { referenceMechanicName = "HallowedWings", rotation = 90, position = new Vector2(-7, 0) },
					new WaitEvent { timeToWait = 1.5f },
					new SetEnemyVisible { visible = false },
				}
			}
		}
	},
	{
		"TrafficLines",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[0].x / 2, 1, lights[0].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = new Vector3(0.5f, 3.5f, 0.5f),
						colorHtml = "#ffff00",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[3].x / 2, 1, lights[3].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#ffff00",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[0].x / 2, 1, lights[0].z / 2),
						eulerAngles = new Vector3(0, 90, 90),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#ffff00",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[3].x / 2, 1, lights[3].z / 2),
						eulerAngles = new Vector3(0, 90, 90),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#ffff00",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Clock.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[0].x / 2, 1, lights[0].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = Vector3.one,
						isBillboard = true,
						colorHtml = "#ffff00",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Clock.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[3].x / 2, 1, lights[3].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = Vector3.one,
						isBillboard = true,
						colorHtml = "#ffff00",
					},
				}
			}
		}
	},
	{
		"SWTrafficLines",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[1].x / 2, 1, lights[1].z / 2),
						eulerAngles = new Vector3(90, 60, 0),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[4].x / 2, 1, lights[4].z / 2),
						eulerAngles = new Vector3(90, 60, 0),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[1].x / 2, 1, lights[1].z / 2),
						eulerAngles = new Vector3(0, 150, 90),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[4].x / 2, 1, lights[4].z / 2),
						eulerAngles = new Vector3(0, 150, 90),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Clock.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[1].x / 2, 1, lights[1].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = Vector3.one,
						isBillboard = true,
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Clock.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[4].x / 2, 1, lights[4].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = Vector3.one,
						isBillboard = true,
						colorHtml = "#9b66ff",
					},
				}
			}
		}
	},
	{
		"NWTrafficLines",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[2].x / 2, 1, lights[2].z / 2),
						eulerAngles = new Vector3(90, 300, 0),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[5].x / 2, 1, lights[5].z / 2),
						eulerAngles = new Vector3(90, 300, 0),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[2].x / 2, 1, lights[2].z / 2),
						eulerAngles = new Vector3(0, 30, 90),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Line.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[5].x / 2, 1, lights[5].z / 2),
						eulerAngles = new Vector3(0, 30, 90),
						scale = new Vector3(0.5f, 3.5f, 1),
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Clock.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[2].x / 2, 1, lights[2].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = Vector3.one,
						isBillboard = true,
						colorHtml = "#9b66ff",
					},
					new SpawnVisualObject {
						textureFilePath = "Mechanics/Resources/Clock.png",
						visualDuration = 5f,
						relativePosition = new Vector3(lights[5].x / 2, 1, lights[5].z / 2),
						eulerAngles = new Vector3(90, 0, 0),
						scale = Vector3.one,
						isBillboard = true,
						colorHtml = "#9b66ff",
					},
				}
			}
		}
	},
	{
		"Exaline",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Rectangle,
			collisionShapeParams = new Vector4(14, 3.5f),
			colorHtml = "#FF4400",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 1.7f },
					new ApplyEffectToPlayers {
						effects = new List<MechanicEffect> {
							new DamageEffect { damageAmount = 50000, damageType = "Magic", name = "Tidal Light" },
							new ApplyStatusEffect { referenceStatusName = "DamageDown" } 
						}
					}
				}
			}
		}
	},
	{
		"FirstExaline",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Rectangle,
			collisionShapeParams = new Vector4(14, 3.5f),
			colorHtml = "#FF4400",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 2.7f },
					new ApplyEffectToPlayers {
						effects = new List<MechanicEffect> {
							new DamageEffect { damageAmount = 50000, damageType = "Magic", name = "Tidal Light" },
							new ApplyStatusEffect { referenceStatusName = "DamageDown" } 
						}
					}
				}
			}
		}
	},
	{
		"HallowedWings",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Rectangle,
			collisionShapeParams = new Vector4(14, 14f),
			colorHtml = "#50ffff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers { effect = new WildChargeDamageEffect { damageAmountFront = 100000, damageAmountBack = 50000, damageType = "Magic", name = "Hallowed Wings" }, },
					new SpawnTargetedEvents { referenceMechanicName = "ApplyWingsVuln", targetingScheme = new TargetSpecificProximityPlayers { targetIds = new List<int> { 0, 1, 2, 3 }, useWildChargeDistanceFormula = true }, },
					new ApplyEffectToPlayers { effect = new KnockbackEffect { knockbackDistance = 8 }  }
				}
			}
		}
	},
	{
		"ApplyWingsVuln",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new ApplyStatusEffect { referenceStatusName = "LesserMagicVuln" } 
			}
		}
	},
	{
		"IceDynamo",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(12), 360, ScaleToSim(2)),
			colorHtml = "#50ffff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ApplyEffectToPlayers 
					{ 
						effects = new List<MechanicEffect> 
						{
							new DamageEffect { damageAmount = 300000, damageType = "Magic", name = "Dark Blizzard III" },
							new ApplyStatusEffect { referenceStatusName = "DamageDown" } 
						}
					},
					new WaitEvent { timeToWait = 0.2f },
				}
			}
		}
	},
	{
		"Aero",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(15), 360),
			colorHtml = "#80ff00",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ApplyEffectToPlayers 
					{ 
						effects = new List<MechanicEffect> 
						{
							new DamageEffect { damageAmount = 10000, damageType = "Magic", name = "Dark Aero III" },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
						}
					},
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers {
						condition = new CheckPlayerIsMechanicTarget(),
						effects = new List<MechanicEffect> {},
						failedConditionEffects = new List<MechanicEffect>
						{
							new KnockbackEffect { knockbackDistance = 11 } 
						}
					}
				}
			}
		}
	},
	{
		"GaiaStack",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(6), 360),
			colorHtml = "#ffff00",
			isTargeted = true,
			mechanic = new CheckNumberOfPlayers
			{
				expressionFormat = "{0} > 3",
				failEvent = new ExecuteMultipleEvents
				{
					events = new List<MechanicEvent>
					{
						new ApplyEffectToPlayers {
						effects = new List<MechanicEffect> 
						{ 
							new DamageEffect { damageAmount = 240000, damageType = "Magic", name = "Unholy Darkness", maxStackAmount = 5 },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
							new ApplyStatusEffect { referenceStatusName = "StackFail" },
						},
					},
					new WaitEvent { timeToWait = 0.2f },
					}
				},
				successEvent = new ExecuteMultipleEvents
				{
					events = new List<MechanicEvent>
					{
						new ApplyEffectToPlayers {
						effects = new List<MechanicEffect> 
						{ 
							new DamageEffect { damageAmount = 240000, damageType = "Magic", name = "Unholy Darkness", maxStackAmount = 5 },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
						},
					},
					new WaitEvent { timeToWait = 0.2f },
					}
				},
			},

		}
	},
	{
		"WaterStack",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(6), 360),
			colorHtml = "#0062cc",
			isTargeted = true,
			mechanic = new CheckNumberOfPlayers
			{
				expressionFormat = "{0} > 3",
				failEvent = new ExecuteMultipleEvents
				{
					events = new List<MechanicEvent>
					{
						new ApplyEffectToPlayers {
						effects = new List<MechanicEffect> 
						{ 
							new DamageEffect { damageAmount = 240000, damageType = "Magic", name = "Dark Water III", maxStackAmount = 5 },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
							new ApplyStatusEffect { referenceStatusName = "StackFail" },
						},
					},
					new WaitEvent { timeToWait = 0.2f },
					}
				},
				successEvent = new ExecuteMultipleEvents
				{
					events = new List<MechanicEvent>
					{
						new ApplyEffectToPlayers {
						effects = new List<MechanicEffect> 
						{ 
							new DamageEffect { damageAmount = 240000, damageType = "Magic", name = "Dark Water III", maxStackAmount = 5 },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
						},
					},
					new WaitEvent { timeToWait = 0.2f },
					}
				},
			},

		}
	},
	{
		"DarkSpread",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(ScaleToSim(6), 360),
			colorHtml = "#412b6d",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new ApplyEffectToPlayers 
					{ 
						effects = new List<MechanicEffect> 
						{
							new DamageEffect { damageAmount = 50000, damageType = "Magic", name = "Dark Eruption" },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
						}
					},
					new WaitEvent { timeToWait = 0.2f },
				}
			}
		}
	},
	{
		"ApplyDoom",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effects = new List<MechanicEffect> {
					new DamageEffect { damageAmount = 99999999, damageType = "TrueDamage", name = "Doom" },
					new RemoveStatusEffect { referenceStatusName = "StackFail" },
				}
			}
		}
	},
	{
		"Doom",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly
			{
				effect = new DamageEffect { damageAmount = 99999999, damageType = "TrueDamage", name = "Doom" }
			}
		}
	},
	{
		"ArenaBoundary",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(25, 360, 7),
			colorHtml = "#8800FF",
			persistentTickInterval = 0.2f,
			persistentMechanic = new ApplyEffectToPlayers { effect = new DamageEffect { damageAmount = 9999999, damageType = "TrueDamage" } },
		}
	},
};

mechanicData.referenceTetherProperties = new Dictionary<string, TetherProperties>
{
	{
		"DragonHead1ADistance",
		new TetherProperties
		{
			visible = false,
			oneTetherPerPlayer = true,
			persistentActivationDelay = 0.5f,
			persistentTickInterval = 0.1f,
			persistentMechanic = new CheckTetherLength
			{
				minDistance = 0.5f,
				maxDistance = float.PositiveInfinity,
				failEvent = new ExecuteMultipleTetherEvents {
					events = new List<TetherEvent>
					{
						new SpawnMechanicAtSource { referenceMechanicName = "DragonExplodeHelper1" },
						new EndTether(),
						new EndSourceMechanic(),
					}
				}
			}
		}
	},
	{
		"DragonHead2ADistance",
		new TetherProperties
		{
			visible = false,
			oneTetherPerPlayer = true,
			persistentActivationDelay = 0.5f,
			persistentTickInterval = 0.1f,
			persistentMechanic = new CheckTetherLength
			{
				minDistance = 0.5f,
				maxDistance = float.PositiveInfinity,
				failEvent = new ExecuteMultipleTetherEvents {
					events = new List<TetherEvent>
					{
						new SpawnMechanicAtSource { referenceMechanicName = "DragonExplodeHelper2" },
						new EndTether(),
						new EndSourceMechanic(),
					}
				}
			}
		}
	},
	{
		"DragonHead1BDistance",
		new TetherProperties
		{
			visible = false,
			oneTetherPerPlayer = true,
			persistentActivationDelay = 0.5f,
			persistentTickInterval = 0.1f,
			persistentMechanic = new CheckTetherLength
			{
				minDistance = 0.5f,
				maxDistance = float.PositiveInfinity,
				failEvent = new ExecuteMultipleTetherEvents {
					events = new List<TetherEvent>
					{
						new SpawnMechanicAtSource { referenceMechanicName = "DragonHead1BActivate" },
						new EndTether(),
					}
				}
			}
		}
	},
	{
		"DragonHead2BDistance",
		new TetherProperties
		{
			visible = false,
			oneTetherPerPlayer = true,
			persistentActivationDelay = 0.5f,
			persistentTickInterval = 0.1f,
			persistentMechanic = new CheckTetherLength
			{
				minDistance = 0.5f,
				maxDistance = float.PositiveInfinity,
				failEvent = new ExecuteMultipleTetherEvents {
					events = new List<TetherEvent>
					{
						new SpawnMechanicAtSource { referenceMechanicName = "DragonHead2BActivate" },
						new EndTether(),
					}
				}
			}
		}
	},
	{
		"DragonHead1CDistance",
		new TetherProperties
		{
			visible = false,
			oneTetherPerPlayer = true,
			persistentActivationDelay = 2f,
			persistentTickInterval = 0.1f,
			persistentMechanic = new CheckTetherLength
			{
				minDistance = 0.5f,
				maxDistance = float.PositiveInfinity,
				failEvent = new ExecuteMultipleTetherEvents {
					events = new List<TetherEvent>
					{
						new SpawnMechanicAtSource { referenceMechanicName = "DragonExplodeHelper1" },
						new EndTether(),
						new EndSourceMechanic(),
					}
				}
			}
		}
	},
	{
		"DragonHead2CDistance",
		new TetherProperties
		{
			visible = false,
			oneTetherPerPlayer = true,
			persistentActivationDelay = 2f,
			persistentTickInterval = 0.1f,
			persistentMechanic = new CheckTetherLength
			{
				minDistance = 0.5f,
				maxDistance = float.PositiveInfinity,
				failEvent = new ExecuteMultipleTetherEvents {
					events = new List<TetherEvent>
					{
						new SpawnMechanicAtSource { referenceMechanicName = "DragonExplodeHelper2" },
						new EndTether(),
						new EndSourceMechanic(),
					}
				}
			}
		}
	},
};

mechanicData.referenceStatusProperties = new Dictionary<string, StatusEffectData>
{
	{
		"MagicVuln",
		new DamageModifier
		{
			statusIconPath = "Mechanics/Resources/MagicVuln.png",
			statusName = "Magic Vulnerability Up",
			statusDescription = "Magic damage taken is increased.",
			damageType = "Magic",
			damageMultiplier = 20,
			duration = 1,
		}
	},
	{
		"LesserMagicVuln",
		new DamageModifier
		{
			statusIconPath = "Mechanics/Resources/MagicVuln.png",
			statusName = "Magic Vulnerability Up",
			statusDescription = "Magic damage taken is increased.",
			damageType = "Magic",
			damageMultiplier = 2,
			duration = 6,
		}
	},
	{
		"StackFail",
		new SpawnMechanicOnReachStacks
		{
			statusIconPath = "Mechanics/Resources/Mortality.png",
			statusName = "Mark of Mortality",
			statusDescription = "Branded with a mark of mortality. Damage dealt is reduced. Too many stacks will result in KO.",
			requiredStacks = 2,
			maxStacks = 2,
			duration = 180,
			referenceMechanicName = "ApplyDoom",
		}
	},
	{
		"Stun",
		new StatusEffectData
		{
			statusIconPath = "Mechanics/Resources/Stun.png",
			statusName = "Stun",
			statusDescription = "Unable to execute actions.",
			duration = 9,
			disableType = DisableType.Actions | DisableType.Movement
		}
	},
	{
		"DamageDown",
		new StatusEffectData
		{
			statusIconPath = "Mechanics/Resources/DamageDown.png",
			statusName = "Damage Down",
			statusDescription = "Suffering an emotional damage down.",
			duration = 180
		}
	},
	{
		"IceWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/IceWaiting.png",
			statusName = "Spell-in-Waiting: Dark Blizzard III",
			statusDescription = "Designated target of Dark Blizzard III, which will activate when this effect expires.",
			duration = 14,
			referenceMechanicName = "IceDynamo",
			shouldKeepOnDeath = true,
		}
	},
	{
		"AeroWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/AeroWaiting.png",
			statusName = "Spell-in-Waiting: Dark Aero III",
			statusDescription = "Designated target of Dark Aero III, which will activate when this effect expires.",
			duration = 14,
			referenceMechanicName = "Aero",
			shouldKeepOnDeath = true,
		}
	},
	{
		"StackWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/GaiaStack.png",
			statusName = "Spell-in-Waiting: Unholy Darkness",
			statusDescription = "Designated target of Unholy Darkness, which will activate when this effect expires.",
			duration = 17,
			referenceMechanicName = "GaiaStack",
			shouldKeepOnDeath = true,
		}
	},
	{
		"WaterWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/Water.png",
			statusName = "Spell-in-Waiting: Dark Water III",
			statusDescription = "Designated target of Dark Water III, which will activate when this effect expires.",
			duration = 12,
			referenceMechanicName = "WaterStack",
			shouldKeepOnDeath = true,
		}
	},
	{
		"SpreadWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/DarkSpread.png",
			statusName = "Spell-in-Waiting: Dark Eruption",
			statusDescription = "Designated target of Dark Eruption, which will activate when this effect expires.",
			duration = 14,
			referenceMechanicName = "DarkSpread",
			shouldKeepOnDeath = true,
		}
	},
	{
		"QuietusWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/Quietus.png",
			statusName = "Spell-in-Waiting: Quietus",
			statusDescription = "Designated target of Quietus, which will activate when this effect expires.",
			duration = 31,
			referenceMechanicName = "Quietus",
			shouldKeepOnDeath = true,
		}
	},
	{
		"Wyrmclaw",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/Wyrmclaw.png",
			statusName = "Wyrmclaw",
			statusDescription = "Shredded by draconic talons. KO will occur when countdown reaches 0.",
			duration = 40,
			referenceMechanicName = "Doom",
			shouldKeepOnDeath = true,
		}
	},
	{
		"Wyrmfang",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/Wyrmfang.png",
			statusName = "Wyrmfang",
			statusDescription = "Torn by draconic teeth. KO will occur when countdown reaches 0.",
			duration = 40,
			referenceMechanicName = "Doom",
			shouldKeepOnDeath = true,
		}
	},
	{
		"ReturnWaiting",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/ReturnWaiting.png",
			statusName = "Spell-in-Waiting: Return",
			statusDescription = "Designated target of Return, which will activate when this effect expires.",
			duration = 33,
			referenceMechanicName = "ReturnSequence",
			shouldKeepOnDeath = true,
		}
	},
	{
		"ReturnPending",
		new SpawnMechanicOnExpire
		{
			statusIconPath = "Mechanics/Resources/Return.png",
			statusName = "Return",
			statusDescription = "Aetherially entwined with the temporal manifold. You will be stunned and drawn back to your aetherial trace when this effect expires.",
			duration = 7,
			referenceMechanicName = "ReturnStun",
			shouldKeepOnDeath = true,
		}
	},
};

mechanicData.mechanicEvents = new List<MechanicEvent>
{
	new SpawnMechanicEvent { referenceMechanicName = "ArenaBoundary" },
	new SpawnVisualObject
	{
		textureFilePath = "Mechanics/Resources/ArenaGaiaMarkers.png",
		visualDuration = float.PositiveInfinity,
		relativePosition = new Vector3(0, -0.001f, 0),
		eulerAngles = new Vector3(90, 0, 0),
		scale = new Vector3(14f, 14f, 1),
	},
	new ExecuteMultipleEvents
	{
		events = new List<MechanicEvent>
		{
			new SpawnMechanicEvent { referenceMechanicName = "GlobalMechanics", position = new Vector2(0, 3) },
		}
	}
};
mechanicData.mechanicPools = new Dictionary<string, List<MechanicEvent>>
{
	{
		"TrafficPool",
		new List<MechanicEvent>
		{
			new SpawnMechanicEvent {referenceMechanicName = "NWTraffic" },
			new SpawnMechanicEvent {referenceMechanicName = "SWTraffic" },
		}
	},
	{
		"EWExaPool",
		new List<MechanicEvent>
		{
			new SpawnMechanicEvent {referenceMechanicName = "SpawnShivaE" },
			new SpawnMechanicEvent {referenceMechanicName = "SpawnShivaW" },
		}
	},
		{
		"NSExaPool",
		new List<MechanicEvent>
		{
			new SpawnMechanicEvent {referenceMechanicName = "SpawnShivaN" },
			new SpawnMechanicEvent {referenceMechanicName = "SpawnShivaS" },
		}
	},
};

var resultText = mechanicData.ToString();

File.WriteAllText($@"{baseOutputPath}\Mechanics\{mechanicName}.json", resultText);
File.WriteAllText($@"{baseOutputPath}\Build\Mechanics\{mechanicName}.json", resultText);
File.WriteAllText($@"{buildOutputPath}\Mechanics\{mechanicName}.json", resultText);

$"Finished writing json to Mechanics/{mechanicName}.json".Dump();