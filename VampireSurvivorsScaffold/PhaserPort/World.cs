/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using Unity.Profiling;
using UnityEngine;

// Image 43: PhaserPort.dll - Assembly: PhaserPort, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 38095-38187

public class World : EventEmitter // TypeDefIndex: 38153
{
	// Fields
	public PhaserScene _scene; // 0x18
	public HashSet<Body> _bodies; // 0x20
	private bool _iteratingOverBodies; // 0x28
	private Stack<Body> _spareBodies; // 0x30
	private HashSet<StaticBody> _staticBodies; // 0x38
	private HashSet<BaseBody> _pendingAdd; // 0x40
	private HashSet<BaseBody> _pendingDestroy; // 0x48
	private ProcessQueue<Collider> _colliders; // 0x50
	private Vector2 _gravity; // 0x58
	public ArcadeBodyBounds _bounds; // 0x60
	public CheckCollisionObject _checkCollision; // 0x68
	private int _fps; // 0x70
	private bool _fixedStep; // 0x74
	private double _elapsed; // 0x78
	private double _frameTime; // 0x80
	private double _frameTimeMS; // 0x88
	private int _stepsLastFrame; // 0x90
	private double _timeScale; // 0x98
	public float OVERLAP_BIAS; // 0xA0
	private float TILE_BIAS; // 0xA4
	private bool _forceX; // 0xA8
	private bool _isPaused; // 0xA9
	private int _total; // 0xAC
	public ArcadeWorldDefaults _defaults; // 0xB0
	private int _maxEntries; // 0xB8
	public bool _useTree; // 0xBC
	private List<Group> _groupsWithRTrees; // 0xC0
	private Dictionary<Group, RBush> _groupRTrees; // 0xC8
	public RBush _staticTree; // 0xD0
	private ArcadeWorldConfig _config; // 0xD8
	private static readonly ProfilerMarker _markerEnableBody; // 0x00
	private static readonly ProfilerMarker MarkerAdd; // 0x08
	private static readonly ProfilerMarker s_updateMarker; // 0x10
	private static readonly ProfilerMarker s_preUpdateMarker; // 0x18
	private static readonly ProfilerMarker s_collidersMarker; // 0x20
	private static readonly ProfilerMarker s_stepMarker; // 0x28
	private static readonly ProfilerMarker s_postUpdateMarker; // 0x30
	private static readonly ProfilerMarker s_drawDebugMarker; // 0x38
	private static readonly ProfilerMarker s_bodyDestructionMarker; // 0x40
	private static readonly ProfilerMarker s_separateMarker; // 0x48
	private static readonly ProfilerMarker s_separateCircleMarker; // 0x50
	private static readonly ProfilerMarker s_separateCircleSqrRtMarker; // 0x58
	private static readonly ProfilerMarker s_intersectsMarker; // 0x60
	private PhaserTile[] _tileCache; // 0xE0
	private static readonly ProfilerMarker s_spriteVsTilemapMarker; // 0x68
	private static readonly ProfilerMarker s_spriteVsTilemapFastMarker; // 0x70
	private static readonly ProfilerMarker s_spriteVsTilemapCallbacksMarker; // 0x78
	private static readonly ProfilerMarker s_separateTileMarker; // 0x80

	// Constructors
	public World() {} // Dummy constructor
	public World(PhaserScene scene, ArcadeWorldConfig config) {} // 0x0000000184C5F460-0x0000000184C5FCF0
	static World() {} // 0x0000000184C66FC0-0x0000000184C67430

	// Methods
	public void enable(ArcadeColliderType obj, PhysicsType bodyType = PhysicsType.DYNAMIC_BODY /* Metadata: 0x01AAC397 */) {} // 0x0000000184C5FCF0-0x0000000184C60060
	public PhaserGameObject enableBody(PhaserGameObject obj, PhysicsType bodyType = PhysicsType.DYNAMIC_BODY /* Metadata: 0x01AAC398 */) => default; // 0x0000000184C60060-0x0000000184C60330
	public BaseBody add(BaseBody body) => default; // 0x0000000184C60330-0x0000000184C60660
	private void disable(ArcadeColliderType obj) {} // 0x0000000184C60660-0x0000000184C60980
	public void disableBody(BaseBody body) {} // 0x0000000184C60980-0x0000000184C60B40
	private void remove(BaseBody body) {} // 0x0000000184C60B40-0x0000000184C60CF0
	public World setBounds(float x, float y, float width, float height, bool? checkLeft = default, bool checkRight = true /* Metadata: 0x01AAC399 */, bool checkUp = true /* Metadata: 0x01AAC39A */, bool checkDown = true /* Metadata: 0x01AAC39B */) => default; // 0x0000000184C60CF0-0x0000000184C60DF0
	public World setBoundsCollision(bool left = true /* Metadata: 0x01AAC39C */, bool right = true /* Metadata: 0x01AAC39D */, bool up = true /* Metadata: 0x01AAC39E */, bool down = true /* Metadata: 0x01AAC39F */) => default; // 0x0000000184C60DF0-0x0000000184C60E40
	public World pause() => default; // 0x0000000184C60E40-0x0000000184C60E70
	public World resume() => default; // 0x0000000184C60E70-0x0000000184C60EA0
	public Collider addCollider(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext) => default; // 0x0000000184C60EA0-0x0000000184C60F80
	public Collider addOverlap(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext) => default; // 0x0000000184C60F80-0x0000000184C61060
	public Collider addColliderDirect(Collider collider) => default; // 0x0000000184C61060-0x0000000184C610C0
	public World removeCollider(Collider collider) => default; // 0x0000000184C610C0-0x0000000184C61190
	public World insertColliderDirect(Collider collider, int position) => default; // 0x0000000184C61190-0x0000000184C612A0
	public void setFPS(int frameRate) {} // 0x0000000184C612A0-0x0000000184C612D0
	public void update() {} // 0x0000000184C612D0-0x0000000184C615E0
	public void step(float delta, bool runBodyStep = true /* Metadata: 0x01AAC3A0 */) {} // 0x0000000184C615E0-0x0000000184C61B40
	private void UpdateGroups() {} // 0x0000000184C61B40-0x0000000184C61CC0
	public void postUpdate() {} // 0x0000000184C61CC0-0x0000000184C62370
	public void updateMotion(Body body, float delta) {} // 0x0000000184C62370-0x0000000184C62490
	public void computeAngularVelocity(Body body, float delta) {} // 0x0000000184C62490-0x0000000184C625A0
	public void computeVelocity(Body body, float delta) {} // 0x0000000184C625A0-0x0000000184C628B0
	private bool separate(BaseBody body1, BaseBody body2, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly, bool intersects = false /* Metadata: 0x01AAC3A1 */) => default; // 0x0000000184C628B0-0x0000000184C62DE0
	public bool separateCircle(BaseBody body1, BaseBody body2, bool overlapOnly, float bias = 0f /* Metadata: 0x01AAC3A2 */) => default; // 0x0000000184C62DE0-0x0000000184C634E0
	public bool intersects(BaseBody body1, BaseBody body2) => default; // 0x0000000184C634E0-0x0000000184C63720
	public bool circleBodyIntersects(BaseBody circle, BaseBody body) => default; // 0x0000000184C5DFE0-0x0000000184C5E0D0
	public bool overlap(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback = null, ArcadePhysicsCallback processCallback = null, CallbackContext callbackContext = null) => default; // 0x0000000184C63720-0x0000000184C63750
	public bool collide(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback = null, ArcadePhysicsCallback processCallback = null, CallbackContext callbackContext = null) => default; // 0x0000000184C63750-0x0000000184C63780
	public bool collideObjects(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C63780-0x0000000184C63FB0
	private bool collideHandler(ArcadeColliderType object1, ArcadeColliderType object2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C63FB0-0x0000000184C64710
	private bool collideSpriteVsSprite(PhaserGameObject sprite1, PhaserGameObject sprite2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C64710-0x0000000184C647E0
	private bool collideSpriteVsGroup(PhaserGameObject sprite, PhysicsGroup group, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C647E0-0x0000000184C64CC0
	private bool collideGroupVsTilemapLayer(Group group, PhaserTilemap tilemapLayer, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C64CC0-0x0000000184C64EF0
	public bool collideSpriteVsTilemapLayer(PhaserGameObject sprite, PhaserTilemap tilemap, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C64EF0-0x0000000184C653A0
	public void collideSpriteVsTilemapLayerFast(PhaserGameObject sprite, PhaserTilemap tilemap, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) {} // 0x0000000184C653A0-0x0000000184C65650
	[Il2CppSetOption(Option.NullChecks, true)]
	private bool collideSpriteVsTilesHandler(PhaserGameObject sprite, BoundsInt bounds, PhaserTile[] tiles, int tilesCount, PhaserTilemap tilemapLayer, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly, bool isLayer) => default; // 0x0000000184C65650-0x0000000184C65A80
	private bool SeparateTile(int i, Body body, PhaserTile tile, ref ArcadeRect tileWorldRect, PhaserTilemap tilemapLayer, float tileBias, bool isLayer) => default; // 0x0000000184C65A80-0x0000000184C65FE0
	private bool TileIntersectsBody(ref ArcadeRect tileWorldRect, BaseBody body) => default; // 0x0000000184C65FE0-0x0000000184C66040
	private bool collideGroupVsGroup(PhysicsGroup group1, PhysicsGroup group2, ArcadePhysicsCallback collideCallback, ArcadePhysicsCallback processCallback, CallbackContext callbackContext, bool overlapOnly) => default; // 0x0000000184C66040-0x0000000184C66280
	public void wrap(ArcadeColliderType obj, float padding = 0f /* Metadata: 0x01AAC3A6 */) {} // 0x0000000184C66280-0x0000000184C663F0
	public void wrapArray(IEnumerable<ArcadeColliderType> objs, float padding = 0f /* Metadata: 0x01AAC3AA */) {} // 0x0000000184C663F0-0x0000000184C665E0
	public void wrapObject(ArcadeColliderType generalObj, float padding = 0f /* Metadata: 0x01AAC3AE */) {} // 0x0000000184C665E0-0x0000000184C66750
	private float Wrap(float v, float left, float right) => default; // 0x0000000184C66750-0x0000000184C66780
	public RBush GetTree(Group group) => default; // 0x0000000184C66780-0x0000000184C667E0
	public RBush addGroupTree(Group group) => default; // 0x0000000184C667E0-0x0000000184C66990
	public void addSubsetGroupTree(Group group, Group parentGroup) {} // 0x0000000184C66990-0x0000000184C66A30
	public void destroyBody(BaseBody body) {} // 0x0000000184C66A30-0x0000000184C66AD0
	private void shutdown() {} // 0x0000000184C66AD0-0x0000000184C66F50
	public void destroy() {} // 0x0000000184C66F50-0x0000000184C66FC0
}

