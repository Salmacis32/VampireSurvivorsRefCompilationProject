/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VampireSurvivors.Data;

// Image 2: VampireSurvivors.Runtime.dll - Assembly: VampireSurvivors.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 13826-18866

namespace VampireSurvivors
{
	public class TPCutsceneDialogueUI : MonoBehaviour // TypeDefIndex: 14247
	{
		// Fields
		[SerializeField]
		private RectTransform _DialoguePanelTransform; // 0x20
		[SerializeField]
		private float _DialoguePanelScaleOutDuration; // 0x28
		[SerializeField]
		private CanvasGroup _BackgroundCanvasGroup; // 0x30
		[SerializeField]
		private CanvasGroup _BloodOverlayCanvasGroup; // 0x38
		[SerializeField]
		private float _BloodScaleInDuration; // 0x40
		[SerializeField]
		private float _BloodFadeOutDuration; // 0x44
		[SerializeField]
		private CanvasGroup _LetterBoxCanvasGroup; // 0x48
		[SerializeField]
		private float _LetterBoxTransitionInTime; // 0x50
		[SerializeField]
		private float _LetterBoxTransitionOutTime; // 0x54
		[Header("Dialogue")]
		[SerializeField]
		private TextMeshProUGUI _CharacterNameText; // 0x58
		[SerializeField]
		private TextMeshProUGUI _DialogueText; // 0x60
		[SerializeField]
		private float _DelayBeforeStartDialogue; // 0x68
		[SerializeField]
		private float _DelayBetweenTextCharacters; // 0x6C
		[SerializeField]
		private float _LineScrollYOffsetPerLine; // 0x70
		[SerializeField]
		private float _LineScrollDuration; // 0x74
		[SerializeField]
		private float _DelayAfterDialogueFinished; // 0x78
		[Header("Portraits")]
		[SerializeField]
		private Image _DraculaPortraitImage; // 0x80
		[SerializeField]
		private Image _RichterPortraitImage; // 0x88
		[SerializeField]
		private Image _DeathPortraitImage; // 0x90
		[SerializeField]
		private float _portraitScaleOutDuration; // 0x98
		[SerializeField]
		private float _portraitScaleInDuration; // 0x9C
		private Vector3 _dialoguePanelStartScale; // 0xA0
		private DraculaCutscene.DialogueCharacter _currentCharacter; // 0xAC
		private Material _dialogueTextMaterial; // 0xB0
		private static readonly int VertexOffsetY; // 0x00
		private const string RichterName = "characterLang/{TP_RICHTER}charName"; // Metadata: 0x019770A5
		private const string DraculaName = "characterLang/{TP_DRACULA}charName"; // Metadata: 0x019770C8
		private const string DeathName = "characterLang/{TP_DEATH}charName"; // Metadata: 0x019770EB
		private Coroutine _scrollTextCoroutine; // 0xB8
		private Coroutine _letterBoxTransitionCoroutine; // 0xC0
		private bool _skipDialogue; // 0xC8
		private bool _letterBoxShowing; // 0xC9
	
		// Constructors
		public TPCutsceneDialogueUI() {} // 0x0000000186F05AD0-0x0000000186F05B40
		static TPCutsceneDialogueUI() {} // 0x0000000186F05B40-0x0000000186F05BA0
	
		// Methods
		public void InitDialogue(ref DraculaCutscene.TPCutsceneDialogue[] dialogue) {} // 0x0000000186F04760-0x0000000186F04910
		public void Init() {} // 0x0000000186F04910-0x0000000186F05040
		public void SkipDialogue() {} // 0x0000000186F05040-0x0000000186F05050
		[IteratorStateMachine(typeof(_Show_d__35))]
		public IEnumerator Show() => default; // 0x0000000186F05050-0x0000000186F050F0
		public void ShowLetterBox() {} // 0x0000000186F050F0-0x0000000186F05180
		[IteratorStateMachine(typeof(_LetterBoxFadeTransition_d__37))]
		private IEnumerator LetterBoxFadeTransition(float startAlpha, float endAlpha, float duration) => default; // 0x0000000186F05180-0x0000000186F05250
		[IteratorStateMachine(typeof(_HideDialoguePanelOnDialogueFinished_d__38))]
		public IEnumerator HideDialoguePanelOnDialogueFinished() => default; // 0x0000000186F05250-0x0000000186F052F0
		[IteratorStateMachine(typeof(_PlayDialogue_d__39))]
		public IEnumerator PlayDialogue(DraculaCutscene.TPCutsceneDialogue dialogue, bool hidePortraitAtEnd = false /* Metadata: 0x019770A3 */, SfxType voiceOverID = SfxType.None /* Metadata: 0x019770A4 */) => default; // 0x0000000186F052F0-0x0000000186F05430
		[IteratorStateMachine(typeof(_ShowDialoguePanel_d__40))]
		private IEnumerator ShowDialoguePanel() => default; // 0x0000000186F05430-0x0000000186F054D0
		[IteratorStateMachine(typeof(_ShowCharacterPortrait_d__41))]
		private IEnumerator ShowCharacterPortrait(DraculaCutscene.DialogueCharacter speakingCharacter) => default; // 0x0000000186F054D0-0x0000000186F05580
		[IteratorStateMachine(typeof(_HideCharacterPortrait_d__42))]
		private IEnumerator HideCharacterPortrait(DraculaCutscene.DialogueCharacter characterToHide) => default; // 0x0000000186F05580-0x0000000186F05630
		[IteratorStateMachine(typeof(_ScaleTransform_d__43))]
		private IEnumerator ScaleTransform(Transform transformToScale, Vector3 startScale, Vector3 endScale, float duration) => default; // 0x0000000186F05630-0x0000000186F05710
		[IteratorStateMachine(typeof(_ShowDialogueText_d__44))]
		private IEnumerator ShowDialogueText(DraculaCutscene.TPCutsceneDialogue dialogue) => default; // 0x0000000186F05710-0x0000000186F05830
		[IteratorStateMachine(typeof(_ScrollText_d__45))]
		private IEnumerator ScrollText() => default; // 0x0000000186F05830-0x0000000186F058D0
		private Transform GetPortraitTransformForCharacter(DraculaCutscene.DialogueCharacter character) => default; // 0x0000000186F058D0-0x0000000186F059A0
		private void OnDestroy() {} // 0x0000000186F059A0-0x0000000186F05AD0
	}
}
