/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using VampireSurvivors.Data;
using Zenject;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors.Graphics
{
	public class PentagramManager : IInitializable, IDisposable // TypeDefIndex: 14528
	{
		// Fields
		private static readonly Dictionary<PentagramType, Texture2D> PentagramTextures; // 0x00
		private static readonly Dictionary<PentagramType, Sprite> PentagramSprites; // 0x08
		private const int RTDepth = 0; // Metadata: 0x0197714D
		private const int RTWidth = 256; // Metadata: 0x0197714E
		private const int RTHeight = 256; // Metadata: 0x01977150
		private Texture2D _circle; // 0x10
		private Color _goodTint; // 0x18
		private Color _badTint; // 0x28
		private Color _sireTint; // 0x38
		private Color[] _tints; // 0x48
		private bool _hasBeenGenerated; // 0x50
		private SignalBus _signalBus; // 0x58
		private Material _pentagramMaterial; // 0x60
		private CommandBuffer _commandBuffer; // 0x68
	
		// Constructors
		public PentagramManager() {} // 0x000000018705BC60-0x000000018705BD60
		static PentagramManager() {} // 0x000000018705BD60-0x000000018705BF00
	
		// Methods
		[Inject]
		private void Construct(SignalBus signalBus) {} // 0x00000001826E9730-0x00000001826E9790
		public void Initialize() {} // 0x0000000187058810-0x0000000187058820
		public void Dispose() {} // 0x0000000187058820-0x00000001870588F0
		public static Texture2D GetTexture(PentagramType pentagram) => default; // 0x00000001870588F0-0x00000001870589E0
		public static Sprite GetSprite(PentagramType pentagram) => default; // 0x00000001870589E0-0x0000000187058AD0
		private void GenerateTextures() {} // 0x0000000187058AD0-0x0000000187059780
		private Texture2D DoBlitter(Sprite[] sprites, Color[] tints, PentagramType type) => default; // 0x0000000187059780-0x000000018705A9E0
		private Texture2D PadTexture(Texture2D texture, int width, int height) => default; // 0x000000018705A9E0-0x000000018705AF40
		private void CopyToRT(Texture2D texture, RenderTexture renderTexture, MaterialType matType = MaterialType.Vfx /* Metadata: 0x0197714C */) {} // 0x000000018705AF40-0x000000018705B030
		private void RenderCircle(Texture2D texture, RenderTexture renderTexture, int width, int height, float circleScale, Color circleTint) {} // 0x000000018705B030-0x000000018705B200
		private void MergeAndSaveTexture(Sprite[] sprites, Color[] tints, PentagramType key, float circleScale, Color circleTint, MaterialType matType) {} // 0x000000018705B200-0x000000018705B9D0
		private void SaveMergedTexture(Texture2D texture, PentagramType key) {} // 0x000000018705B9D0-0x000000018705BAF0
		private void SaveMergedSprite(Sprite sprite, PentagramType key) {} // 0x000000018705BAF0-0x000000018705BC60
	}
}
