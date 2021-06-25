<Query Kind="Statements">
  <Reference>D:\src\Unity\XivMechanicSimNetworked\Library\ScriptAssemblies\Assembly-CSharp.dll</Reference>
  <Reference>&lt;ProgramFilesX64&gt;\Unity\Hub\Editor\2020.3.6f1\Editor\Data\Managed\Newtonsoft.Json.dll</Reference>
  <Reference>&lt;ProgramFilesX64&gt;\Unity\Hub\Editor\2020.3.6f1\Editor\Data\Managed\UnityEngine\UnityEngine.CoreModule.dll</Reference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>UnityEngine</Namespace>
</Query>

var mechanicName = "WormholeDemo";
var baseOutputPath = @"D:\src\Unity\XivMechanicSimNetworked";
var buildOutputPath = @"D:\src\Unity\xiv-sim-mechanics";

JsonConvert.DefaultSettings = () =>
{
	return new JsonSerializerSettings
	{
		NullValueHandling = NullValueHandling.Ignore,
		TypeNameHandling = TypeNameHandling.Auto,
		DefaultValueHandling = DefaultValueHandling.Ignore
	};
};

var mechanicData = new MechanicData();

var limitcutGap = 1.45f;

mechanicData.referenceMechanicProperties = new Dictionary<string, MechanicProperties>
{
	{
		"LimitCutSequence",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new StartCastBar { castName = "Limit Cut", duration = 2 },
					new WaitEvent { timeToWait = 2 },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-1", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{0}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-2", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{1}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-3", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{2}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-4", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{3}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-5", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{4}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-6", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{5}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-7", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{6}, dropExtraEvents = true } },
					new SpawnTargetedEvents { referenceMechanicName = "LimitCutMarker-8", targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int>{7}, dropExtraEvents = true } },
					
					new WaitEvent { timeToWait = 9 - limitcutGap },
					new SetEnemyVisible  { visible = false },
					new WaitEvent { timeToWait = limitcutGap },
					new SetEnemyMovement { movementTime = 0.1f, moveToTarget = new TargetSpecificPlayerIds { targetIds = new List<int>{0} }, position = new Vector3(0, -1) },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyMovement { movementTime = -1, moveToTarget =new TargetSpecificPlayerIds { targetIds = new List<int>{0} } },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "AlphaSword", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {0} } },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "BlasstyCharge", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {1} } },
					new SetEnemyVisible { visible = false },

					new WaitEvent { timeToWait = limitcutGap },
					new SetEnemyMovement { movementTime = 0.1f, moveToTarget = new TargetSpecificPlayerIds { targetIds = new List<int>{2} }, position = new Vector3(0, -1) },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyMovement { movementTime = -1, moveToTarget =new TargetSpecificPlayerIds { targetIds = new List<int>{2} } },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "AlphaSword", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {2} } },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "BlasstyCharge", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {3} } },
					new SetEnemyVisible { visible = false },
					
					new WaitEvent { timeToWait = limitcutGap },
					new SetEnemyMovement { movementTime = 0.1f, moveToTarget = new TargetSpecificPlayerIds { targetIds = new List<int>{4} }, position = new Vector3(0, -1) },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyMovement { movementTime = -1, moveToTarget =new TargetSpecificPlayerIds { targetIds = new List<int>{4} } },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "AlphaSword", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {4} } },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "BlasstyCharge", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {5} } },
					new SetEnemyVisible { visible = false },

					new WaitEvent { timeToWait = limitcutGap },
					new SetEnemyMovement { movementTime = 0.1f, moveToTarget = new TargetSpecificPlayerIds { targetIds = new List<int>{6} }, position = new Vector3(0, -1) },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyMovement { movementTime = -1, moveToTarget =new TargetSpecificPlayerIds { targetIds = new List<int>{6} } },
					new WaitEvent { timeToWait = 0.1f },
					new SetEnemyVisible { visible = true },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "AlphaSword", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {6} } },
					new WaitEvent { timeToWait = 1.5f },
					new SpawnTargetedEvents { referenceMechanicName = "BlasstyCharge", isPositionRelative = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {7} } },
					new SetEnemyVisible { visible = false },
					
					new ReshufflePlayerIds()
				}
			}
		}
	},
	{
		"AlexMechanics",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 5 },
					new StartCastBar { castName = "Void of Repentence", duration = 3 },
					new WaitEvent { timeToWait = 5 },
					new ExecuteRandomEvents { mechanicPoolName = "Tower-Pool" },
					
					new WaitEvent { timeToWait = 6 },
					new StartCastBar { castName = "Sacrament", duration = 6 },

					new WaitEvent { timeToWait = 6 },
					new SpawnMechanicEvent { referenceMechanicName = "Sacrament", isPositionRelative = true, isRotationRelative = true },
					new SpawnMechanicEvent { referenceMechanicName = "Sacrament", isPositionRelative = true, isRotationRelative = true, rotation = -90 },
					new SpawnMechanicEvent { referenceMechanicName = "Sacrament", isPositionRelative = true, isRotationRelative = true, rotation = 90 },

					new WaitEvent { timeToWait = 7 },
					new StartCastBar { castName = "Incinerating Heat", duration = 5 },
					new SpawnTargetedEvents { referenceMechanicName = "Stack", spawnOnTarget = true, targetingScheme = new TargetRandomPlayers { numTargets = 1 } },

					new WaitEvent { timeToWait = 4 },
					new SpawnMechanicEvent { referenceMechanicName = "ClearVulns" },
					new SpawnTargetedEvents { referenceMechanicName = "Enumeration", spawnOnTarget = true, targetingScheme = new TargetSpecificPlayerIdsByClass { classType = PlayerClassType.Dps, targetIds = new List<int> {0, 1}, dropExtraEvents = true } },

					new WaitEvent { timeToWait = float.PositiveInfinity }
				}
			}
		}
	},
	{
		"BJMechanics",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 2 },
					new StartCastBar { castName = "Link-Up", duration = 3 },
					new WaitEvent { timeToWait = 4 },
					
					new SpawnEnemy
					{
						enemyName = "Steam Chakram",
						textureFilePath = "Mechanics/Resources/Chakram.png",
						maxHp = int.MaxValue,
						baseMoveSpeed = 2,
						hitboxSize = 2,
						isPositionRelative = true,
						isRotationRelative = true,
						position = new Vector3 (5, 2),
						referenceMechanicName = "ChakramMechanics",
						isTargetable = false,
						isVisible = false,
					},
					new SpawnEnemy
					{
						enemyName = "Steam Chakram",
						textureFilePath = "Mechanics/Resources/Chakram.png",
						maxHp = int.MaxValue,
						baseMoveSpeed = 2,
						hitboxSize = 2,
						isPositionRelative = true,
						isRotationRelative = true,
						position = new Vector3 (-5, 2),
						referenceMechanicName = "ChakramMechanics",
						isTargetable = false,
						isVisible = false,
					},

					new WaitEvent { timeToWait = 5 },
					new StartCastBar { castName = "Super Jump", duration = 4 },
					new WaitEvent { timeToWait = 4 },

					new SetEnemyMovement {movementTime = 0.2f, moveToTarget = new TargetSpecificProximityPlayers { targetNthFarthest = true, targetIds = new List<int> {0} } },
					new SpawnTargetedEvents { referenceMechanicName = "SuperJump", isPositionRelative = true, spawnOnTarget = true, targetingScheme = new TargetSpecificPlayerIds { targetIds = new List<int> {0} } },

					new WaitEvent { timeToWait = 0.2f },
					new SetEnemyMovement {movementTime = -1, moveToTarget = new TargetSpecificProximityPlayers { targetNthFarthest = true, targetIds = new List<int> {0} } },
					new SpawnMechanicEvent { referenceMechanicName = "ApocRay", isPositionRelative = true, isRotationRelative = true },

					new WaitEvent { timeToWait = 12.3f },
					new StartCastBar { castName = "Missile Command", duration = 3 },

					new WaitEvent {timeToWait = float.PositiveInfinity }
				}
			}
		}
	},
	{
		"ChakramMechanics",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject { visualDuration = 6, colorHtml = "#8b4800", textureFilePath = "Mechanics/Resources/Chakram.png", relativePosition = new Vector3(0, 0.2f, 0), eulerAngles = new Vector3(90, 0, 0), isRotationRelative = true },
					new SpawnTargetedEvents { referenceMechanicName = "ChakramAoe", isPositionRelative = true, targetingScheme = new TargetRandomPlayers { numTargets = 1 } },
					new WaitEvent { timeToWait = 1 },
					new StartCastBar { castName = "Eye of the Chakram", duration = 5 },
					new WaitEvent { timeToWait = 5 },
				}
			}
		}
	},
	{
		"SnapshotTarget",
		new MechanicProperties {
			isTargeted = false,
		}
	},
	{
		"SetVisible",
		new MechanicProperties {
			visible = true,
		}
	},
	{
		"ChakramAoe",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Rectangle,
			collisionShapeParams = new Vector4(40, 2),
			colorHtml = "#ff7e00",
			isTargeted = true,
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 1 },
					new ModifyMechanicEvent { referenceMechanicName = "SnapshotTarget" },
					new WaitEvent { timeToWait = 4.8f },
					new ModifyMechanicEvent { referenceMechanicName = "SetVisible" },
					new ApplyEffectToPlayers {
						effects = new List<MechanicEffect>
						{
							new DamageEffect { damageAmount = 300000, damageType = "Damage", name = "Eye of the Chakram" },
							new KnockbackEffect { knockbackDistance = 10 },
						}
					}
				}
			}
		}
	},
	{
		"TowerFail",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(50, 360),
			colorHtml = "#FF0000",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers {
						effect = new DamageEffect { damageAmount = 9999999, damageType = "TrueDamage", name = "Tower Failed" }
					}
				}
			}
		}
	},
	{
		"TowerSet-A",
		new MechanicProperties {
			visible = true,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "Tower-Offset", rotation = 22.5f },
					new SpawnMechanicEvent { referenceMechanicName = "Tower-Offset", rotation = 202.5f },
				}
			}
		}
	},
	{
		"TowerSet-B",
		new MechanicProperties {
			visible = true,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "Tower-Offset", rotation = -22.5f },
					new SpawnMechanicEvent { referenceMechanicName = "Tower-Offset", rotation = -202.5f },
				}
			}
		}
	},
	{
		"Tower-Offset",
		new MechanicProperties {
			visible = false,
			mechanic = new SpawnMechanicEvent { referenceMechanicName = "Tower-A", position = new Vector2(4.22f, 0), isPositionRelative = true, isRotationRelative = true },
		}
	},
	{
		"Tower-A",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(3, 360),
			colorHtml = "#0048ff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent> {
					new WaitEvent { timeToWait = 15 },
					new SpawnMechanicEvent { referenceMechanicName = "TowerFail", isPositionRelative = true }
				}
			},
			persistentActivationDelay = 10,
			persistentTickInterval = 0.1f,
			persistentMechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new CheckNumberOfPlayers
					{
						expressionFormat = "{0} > 0",
						successEvent = new ExecuteMultipleEvents {
							events = new List<MechanicEvent> {
								new ApplyEffectToPlayers {
									effects = new List<MechanicEffect>
									{
										new DamageEffect {damageAmount = 30000, damageType = "Magic", name = "Repentance" },
										new ApplyStatusEffect { referenceStatusName = "MagicVuln" }
									}
								},
								new SpawnMechanicEvent { referenceMechanicName = "Tower-B", isPositionRelative = true },
								new EndMechanic()
							}
						}
					},
				}
			}
		}
	},
	{
		"Tower-B",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(2, 360),
			colorHtml = "#0048ff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent> {
					new WaitEvent { timeToWait = 5 },
					new SpawnMechanicEvent { referenceMechanicName = "TowerFail", isPositionRelative = true },
				}
			},
			persistentActivationDelay = 1,
			persistentTickInterval = 0.1f,
			persistentMechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new CheckNumberOfPlayers
					{
						expressionFormat = "{0} > 0",
						successEvent = new ExecuteMultipleEvents {
							events = new List<MechanicEvent> {
								new ApplyEffectToPlayers {
									effects = new List<MechanicEffect>
									{
										new DamageEffect {damageAmount = 30000, damageType = "Magic", name = "Repentance" },
										new ApplyStatusEffect { referenceStatusName = "MagicVuln" }
									}
								},
								new SpawnMechanicEvent { referenceMechanicName = "Tower-C", isPositionRelative = true },
								new EndMechanic()
							}
						}
					},
				}
			}
		}
	},
	{
		"Tower-C",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(1, 360),
			colorHtml = "#0048ff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent> {
					new WaitEvent { timeToWait = 5 },
					new SpawnMechanicEvent { referenceMechanicName = "TowerFail", isPositionRelative = true }
				}
			},
			persistentActivationDelay = 1,
			persistentTickInterval = 0.1f,
			persistentMechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new CheckNumberOfPlayers
					{
						expressionFormat = "{0} > 0",
						successEvent = new ExecuteMultipleEvents {
							events = new List<MechanicEvent> {
								new ApplyEffectToPlayers {
									effects = new List<MechanicEffect>
									{
										new DamageEffect {damageAmount = 30000, damageType = "Magic", name = "Repentance" },
										new ApplyStatusEffect { referenceStatusName = "MagicVuln" }
									}
								},
								new EndMechanic()
							}
						}
					},
				}
			}
		}
	},
	{
		"Sacrament",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Rectangle,
			collisionShapeParams = new Vector4(40, 6f),
			colorHtml = "#a0bbff",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers {
						effect = new DamageEffect { damageAmount = 420000, damageType = "Damage", name = "Sacrament" },
					}
				}
			}
		}
	},
	{
		"AlphaSword",
		new MechanicProperties
		{
			collisionShapeParams = new Vector4(10, 90),
			colorHtml = "#ffff00",
			visible = true,
			isTargeted = true,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers
					{
						effects = new List<MechanicEffect>
						{
							new DamageEffect {damageAmount = 50000, damageType = "Physical", name = "Alpha Sword" },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
							new ApplyStatusEffect { referenceStatusName = "PhysVuln" },
							new KnockbackEffect { knockbackDistance = 2, canArmsLength = true }
						}
					}
				}
			}
		}
	},
	{
		"BlasstyCharge",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Rectangle,
			collisionShapeParams = new Vector4(40, 2),
			colorHtml = "#ffff00",
			visible = true,
			isTargeted = true,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers
					{
						condition = new CheckPlayerFacingAway(),
						effects = new List<MechanicEffect>
						{
							new DamageEffect {damageAmount = 45000, damageType = "Physical", name = "Super Blassty Charge" },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
							new ApplyStatusEffect { referenceStatusName = "PhysVuln" },
							new KnockbackEffect { knockbackDistance = 10, canArmsLength = true }
						},
						failedConditionEffects = new List<MechanicEffect>
						{
							new DamageEffect {damageAmount = 45000, damageType = "Physical", name = "Super Blassty Charge" },
							new ApplyStatusEffect { referenceStatusName = "MagicVuln" },
							new ApplyStatusEffect { referenceStatusName = "PhysVuln" },
						},
					}
				}
			}
		}
	},
	{
		"SuperJump",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(1.5f, 360),
			colorHtml = "#ffc600",
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new WaitEvent { timeToWait = 0.2f },
					new ApplyEffectToPlayers {
						condition = new CheckPlayerIsMechanicTarget(),
						effects = new List<MechanicEffect>
						{
							new DamageEffect { damageAmount = 40000, damageType = "Damage", name = "Super Jump" },
						},
						failedConditionEffects = new List<MechanicEffect>
						{
							new DamageEffect { damageAmount = 40000, damageType = "Damage", name = "Super Jump" },
							new KnockbackEffect { knockbackDistance = 10},
						}
					}
				}
			}
		}
	},
	{
		"ApocRay",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(11, 100),
			colorHtml = "#ff8400",
			mechanic = new WaitEvent { timeToWait = 6 },
			persistentTickInterval = 0.3f,
			persistentActivationDelay = 2,
			persistentMechanic = new ApplyEffectToPlayers { effect = new DamageEffect { damageAmount = 400000, damageType = "Damage", name = "Apocalyptic Ray" } },
		}
	},
	{
		"Stack",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(1.5f, 360),
			colorHtml = "#ff4200",
			isTargeted = true,
			followSpeed = 10000,
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/Mark1.png", colorHtml = "#f0ba00", visualDuration = 5, spawnOnPlayer = true, relativePosition = Vector3.up * 0.8f, scale = new Vector3(0.8f, 0.8f, 1), isBillboard = true },
					new WaitEvent { timeToWait = 5 },
					new ModifyMechanicEvent { referenceMechanicName = "SetVisible" },
					new ApplyEffectToPlayers { effect = new DamageEffect { damageAmount = 800000, damageType = "Damage", name = "Incinerating Heat", maxStackAmount = 8 } },
				}
			}
		}
	},
	{
		"Enumeration",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(1.5f, 360),
			colorHtml = "#fffe9d",
			isTargeted = true,
			followSpeed = 10000,
			visible = true,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnVisualObject { textureFilePath = "Mechanics/Resources/LimitCut-3.png", colorHtml = "#00ffba", visualDuration = 5, spawnOnPlayer = true, relativePosition = Vector3.up * 0.8f, scale = Vector3.one, isBillboard = true },
					new WaitEvent { timeToWait = 5 },
					new CheckNumberOfPlayers {
						expressionFormat = "{0} = 3",
						successEvent = new ApplyEffectToPlayers { effect = new ApplyStatusEffect { referenceStatusName = "Enumeration" } },
						failEvent = new ApplyEffectToPlayers { effect = new DamageEffect { damageAmount = 9999999, damageType = "TrueDamage", name = "Enumeration" } },
					}
				}
			}
		}
	},
	{
		"ClearVulns",
		new MechanicProperties
		{
			collisionShape = CollisionShape.Round,
			collisionShapeParams = new Vector4(100, 360),
			visible = false,
			mechanic = new ApplyEffectToPlayers
			{
				effects = new List<MechanicEffect> {
					new RemoveStatusEffect { referenceStatusName = "MagicVuln" },
					new RemoveStatusEffect { referenceStatusName = "PhysVuln" },
				}
			}
		}
	},
	{
		"Spawn-Alex",
		new MechanicProperties
		{
			visible = false,
			mechanic = new SpawnEnemy
			{
				enemyName = "Alexander Prime",
				textureFilePath = "Mechanics/Resources/AlexPrime.png",
				colorHtml = "#8b4800",
				maxHp = int.MaxValue,
				baseMoveSpeed = 2,
				hitboxSize = 3,
				visualPosition = new Vector3(0, 2f, 0),
				visualScale = Vector3.one * 4,
				position = new Vector2(0, 6),
				rotation = 180,
				referenceMechanicName = "AlexMechanics",
				isTargetable = false,
			},
		}
	},
	{
		"Spawn-BJ-A",
		new MechanicProperties
		{
			visible = false,
			mechanic = new SpawnEnemy
			{
				enemyName = "Brute Justice",
				textureFilePath = "Mechanics/Resources/BruteJustice.png",
				colorHtml = "#8b4800",
				maxHp = int.MaxValue,
				baseMoveSpeed = 2,
				hitboxSize = 2,
				visualPosition = new Vector3(0, 1.5f, 0),
				visualScale = Vector3.one * 3,
				position = new Vector2(5, -5),
				rotation = -45,
				referenceMechanicName = "BJMechanics",
				isTargetable = false,
			},
		}
	},
	{
		"Spawn-BJ-B",
		new MechanicProperties
		{
			visible = false,
			mechanic = new SpawnEnemy
			{
				enemyName = "Alexander Prime",
				textureFilePath = "Mechanics/Resources/BruteJustice.png",
				colorHtml = "#8b4800",
				maxHp = int.MaxValue,
				baseMoveSpeed = 2,
				hitboxSize = 2,
				visualPosition = new Vector3(0, 1.5f, 0),
				visualScale = Vector3.one * 3,
				position = new Vector2(-5, -5),
				rotation = 45,
				referenceMechanicName = "BJMechanics",
				isTargetable = false,
			},
		}
	},
	{
		"Spawn-CruiseChaser-A",
		new MechanicProperties
		{
			visible = false,
			mechanic = new SpawnEnemy
			{
				enemyName = "Cruise Chaser",
				textureFilePath = "Mechanics/Resources/CruiseChaser.png",
				colorHtml = "#8b4800",
				maxHp = int.MaxValue,
				baseMoveSpeed = 2,
				hitboxSize = 2,
				visualPosition = new Vector3(0, 1, 0),
				visualScale = Vector3.one * 2,
				position = new Vector2(-5, -5),
				rotation = 45,
				referenceMechanicName = "LimitCutSequence",
				isTargetable = false,
			},
		}
	},
	{
		"Spawn-CruiseChaser-B",
		new MechanicProperties
		{
			visible = false,
			mechanic = new SpawnEnemy
			{
				enemyName = "Cruise Chaser",
				textureFilePath = "Mechanics/Resources/CruiseChaser.png",
				colorHtml = "#8b4800",
				maxHp = int.MaxValue,
				baseMoveSpeed = 2,
				hitboxSize = 2,
				visualPosition = new Vector3(0, 1, 0),
				visualScale = Vector3.one * 2,
				position = new Vector2(5, -5),
				rotation = -45,
				referenceMechanicName = "LimitCutSequence",
				isTargetable = false,
			},
		}
	},
	{
		"SpawnBosses-A",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "Spawn-Alex" },
					new SpawnMechanicEvent { referenceMechanicName = "Spawn-BJ-A" },
					new SpawnMechanicEvent { referenceMechanicName = "Spawn-CruiseChaser-A" },
				}
			}
		}
	},
	{
		"SpawnBosses-B",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ExecuteMultipleEvents
			{
				events = new List<MechanicEvent>
				{
					new SpawnMechanicEvent { referenceMechanicName = "Spawn-Alex" },
					new SpawnMechanicEvent { referenceMechanicName = "Spawn-BJ-B" },
					new SpawnMechanicEvent { referenceMechanicName = "Spawn-CruiseChaser-B" },
				}
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
	{
		"EnumerationOverlap",
		new MechanicProperties
		{
			visible = false,
			mechanic = new ApplyEffectToTargetOnly { effect = new DamageEffect { damageAmount = 9999999, damageType = "TrueDamage", name = "Enumeration" } },
		}
	},
};

for (int i = 1; i <= 8; i++)
{
	var scale = Vector3.one * 0.5f;
	if (i == 5) {
		scale = new Vector3(1.78f, 1, 1) * 0.5f;
	}
	else if (i > 5)
	{
		scale = new Vector3(2.16f, 1, 1) * 0.5f;
	}
	mechanicData.referenceMechanicProperties[$"LimitCutMarker-{i}"] = new MechanicProperties {
		visible = false,
		mechanic = new SpawnVisualObject {
			textureFilePath = $"Mechanics/Resources/LimitCut-{i}.png",
			colorHtml = i % 2 == 0 ? "#ff0000" : "#0000ff",
			visualDuration = 8,
			scale = scale,
			relativePosition = Vector3.up,
			isBillboard = true,
			spawnOnPlayer = true,
		}
	};
}

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
			damageMultiplier = 8,
			duration = 10,
		}
	},
	{
		"Enumeration",
		new CheckConditionOnApply
		{
			statusIconPath = "Mechanics/Resources/MagicVuln.png",
			statusName = "Magic Vulnerability Up",
			condition = new CheckPlayerStatus { statusName = "Magic Vulnerability Up" },
			successMechanicName = "EnumerationOverlap",
			duration = 1,
		}
	},
	{
		"PhysVuln",
		new DamageModifier
		{
			statusIconPath = "Mechanics/Resources/PhysVuln.png",
			statusName = "Physical Vulnerability Up",
			statusDescription = "Physical damage taken is increased.",
			damageType = "Physical",
			damageMultiplier = 8,
			duration = 17,
		}
	}
};

mechanicData.mechanicEvents = new List<MechanicEvent>
{
	new SpawnMechanicEvent { referenceMechanicName = "ArenaBoundary" },
	new SpawnVisualObject
	{
		textureFilePath = "Mechanics/Resources/ArenaCircle.png",
		visualDuration = float.PositiveInfinity,
		relativePosition = new Vector3(0, -0.001f, 0),
		eulerAngles = new Vector3(90, 0, 0),
		scale = new Vector3(15.8637f, 15.8637f, 1),
	},
	new ExecuteMultipleEvents
	{
		events = new List<MechanicEvent>
		{
			new WaitEvent { timeToWait = 2 },
			new ExecuteRandomEvents { mechanicPoolName = "Spawn-Bosses-Pool" },
		}
	}
};
mechanicData.mechanicPools = new Dictionary<string, List<MechanicEvent>>
{
	{
		"Tower-Pool",
		new List<MechanicEvent>
		{
			new SpawnMechanicEvent { referenceMechanicName = "TowerSet-A" },
			new SpawnMechanicEvent { referenceMechanicName = "TowerSet-B" },
		}
	},
	{
		"Spawn-Bosses-Pool",
		new List<MechanicEvent>
		{
			new SpawnMechanicEvent { referenceMechanicName = "SpawnBosses-A" },
			new SpawnMechanicEvent { referenceMechanicName = "SpawnBosses-B" },
		}
	},
};

var resultText = mechanicData.ToString();

File.WriteAllText($@"{baseOutputPath}\Mechanics\{mechanicName}.json", resultText);
File.WriteAllText($@"{baseOutputPath}\Build\Mechanics\{mechanicName}.json", resultText);
File.WriteAllText($@"{buildOutputPath}\Mechanics\{mechanicName}.json", resultText);

$"Finished writing json to Mechanics/{mechanicName}.json".Dump();