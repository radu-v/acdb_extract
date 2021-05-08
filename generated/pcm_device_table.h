#include "snd_device_enum.h"

static int pcm_device_table[AUDIO_USECASE_MAX][2] = {
	[USECASE_AUDIO_PLAYBACK_DEEP_BUFFER] = {0, 0},
	[USECASE_AUDIO_PLAYBACK_LOW_LATENCY] = {0, 15},
	[USECASE_AUDIO_PLAYBACK_MULTI_CH] = {15, 15},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD] = {15, 1},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD2] = {1, 1},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD3] = {1, 9},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD4] = {9, 9},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD5] = {9, 17},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD6] = {17, 17},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD7] = {17, 18},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD8] = {18, 18},
	[USECASE_AUDIO_PLAYBACK_OFFLOAD9] = {18, 34},
	[USECASE_AUDIO_PLAYBACK_ULL] = {34, 34},
	[USECASE_AUDIO_PLAYBACK_MMAP] = {34, 35},
	[14] = {35, 35}, /* unknown usecase index */
	[USECASE_AUDIO_PLAYBACK_FM] = {35, 36},
	[USECASE_AUDIO_HFP_SCO] = {36, 36},
	[USECASE_AUDIO_HFP_SCO_WB] = {36, 37},
	[USECASE_AUDIO_RECORD] = {37, 37},
	[USECASE_AUDIO_RECORD_COMPRESS] = {37, 38},
	[USECASE_AUDIO_RECORD_COMPRESS2] = {38, 38},
	[USECASE_AUDIO_RECORD_COMPRESS3] = {38, 39},
	[USECASE_AUDIO_RECORD_COMPRESS4] = {39, 39},
	[USECASE_AUDIO_RECORD_COMPRESS5] = {39, 4},
	[USECASE_AUDIO_RECORD_COMPRESS6] = {4, 4},
	[USECASE_AUDIO_RECORD_LOW_LATENCY] = {4, 18},
	[USECASE_AUDIO_RECORD_FM_VIRTUAL] = {18, 18},
	[27] = {18, 1}, /* unknown usecase index */
	[USECASE_AUDIO_PLAYBACK_VOIP] = {1, 1},
	[USECASE_AUDIO_RECORD_VOIP] = {1, 5},
	[USECASE_VOICE_CALL] = {5, 6},
	[USECASE_AUDIO_RECORD_MMAP] = {6, 5},
	[USECASE_VOICE2_CALL] = {5, 23},
	[USECASE_VOLTE_CALL] = {23, 5},
	[USECASE_QCHAT_CALL] = {5, 23},
	[USECASE_VOWLAN_CALL] = {23, 0},
	[USECASE_VOICEMMODE1_CALL] = {0, 0},
	[USECASE_VOICEMMODE2_CALL] = {0, 19},
	[38] = {19, 19}, /* unknown usecase index */
	[USECASE_INCALL_REC_UPLINK] = {19, -1},
	[USECASE_INCALL_REC_DOWNLINK] = {-1, -1},
	[USECASE_INCALL_REC_UPLINK_AND_DOWNLINK] = {-1, -1},
	[42] = {-1, -1}, /* unknown usecase index */
	[43] = {-1, -1}, /* unknown usecase index */
	[44] = {-1, -1}, /* unknown usecase index */
	[USECASE_INCALL_MUSIC_UPLINK] = {-1, -1},
	[46] = {-1, -1}, /* unknown usecase index */
	[USECASE_AUDIO_SPKR_CALIB_RX] = {-1, -1},
	[USECASE_AUDIO_SPKR_CALIB_TX] = {-1, -1},
	[USECASE_AUDIO_PLAYBACK_AFE_PROXY] = {-1, 15},
	[USECASE_AUDIO_RECORD_AFE_PROXY] = {15, 15},
	[USECASE_AUDIO_PLAYBACK_SILENCE] = {15, 1},
	[52] = {1, 1}, /* unknown usecase index */
	[53] = {1, 1}, /* unknown usecase index */
	[54] = {1, 1}, /* unknown usecase index */
	[55] = {1, 16}, /* unknown usecase index */
	[56] = {16, 16}, /* unknown usecase index */
	[57] = {16, 16}, /* unknown usecase index */
	[58] = {16, 16}, /* unknown usecase index */
	[59] = {16, 2}, /* unknown usecase index */
	[60] = {2, 2}, /* unknown usecase index */
	[61] = {2, 18}, /* unknown usecase index */
	[USECASE_AUDIO_A2DP_ABR_FEEDBACK] = {18, 18},
};