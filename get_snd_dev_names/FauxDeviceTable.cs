using System.Collections.Generic;
namespace AcdbData
{
    public static class AcdbData
    {
        public static readonly Dictionary<AcdbDevices, string> FauxDeviceTable = new()
        {
            [AcdbDevices.SND_DEVICE_NONE] = "SND_DEVICE_NONE",
            [AcdbDevices.SND_DEVICE_OUT_HANDSET] = "SND_DEVICE_OUT_HANDSET",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER] = "SND_DEVICE_OUT_SPEAKER",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_EXTERNAL_1] = "SND_DEVICE_OUT_SPEAKER_EXTERNAL_1",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_EXTERNAL_2] = "SND_DEVICE_OUT_SPEAKER_EXTERNAL_2",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_REVERSE] = "SND_DEVICE_OUT_SPEAKER_REVERSE",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_VBAT] = "SND_DEVICE_OUT_SPEAKER_VBAT",
            [AcdbDevices.SND_DEVICE_OUT_LINE] = "SND_DEVICE_OUT_LINE",
            [AcdbDevices.SND_DEVICE_OUT_HEADPHONES] = "SND_DEVICE_OUT_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_HEADPHONES_DSD] = "SND_DEVICE_OUT_HEADPHONES_DSD",
            [AcdbDevices.SND_DEVICE_OUT_HEADPHONES_44_1] = "SND_DEVICE_OUT_HEADPHONES_44_1",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_HEADPHONES] = "SND_DEVICE_OUT_SPEAKER_AND_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_LINE] = "SND_DEVICE_OUT_SPEAKER_AND_LINE",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_HEADPHONES_EXTERNAL_1] = "SND_DEVICE_OUT_SPEAKER_AND_HEADPHONES_EXTERNAL_1",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_HEADPHONES_EXTERNAL_2] = "SND_DEVICE_OUT_SPEAKER_AND_HEADPHONES_EXTERNAL_2",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_HANDSET] = "SND_DEVICE_OUT_VOICE_HANDSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER] = "SND_DEVICE_OUT_VOICE_SPEAKER",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_VBAT] = "SND_DEVICE_OUT_VOICE_SPEAKER_VBAT",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_2] = "SND_DEVICE_OUT_VOICE_SPEAKER_2",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_2_VBAT] = "SND_DEVICE_OUT_VOICE_SPEAKER_2_VBAT",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_HEADPHONES] = "SND_DEVICE_OUT_VOICE_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_LINE] = "SND_DEVICE_OUT_VOICE_LINE",
            [AcdbDevices.SND_DEVICE_OUT_HDMI] = "SND_DEVICE_OUT_HDMI",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_HDMI] = "SND_DEVICE_OUT_SPEAKER_AND_HDMI",
            [AcdbDevices.SND_DEVICE_OUT_DISPLAY_PORT] = "SND_DEVICE_OUT_DISPLAY_PORT",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_DISPLAY_PORT] = "SND_DEVICE_OUT_SPEAKER_AND_DISPLAY_PORT",
            [AcdbDevices.SND_DEVICE_OUT_BT_SCO] = "SND_DEVICE_OUT_BT_SCO",
            [AcdbDevices.SND_DEVICE_OUT_BT_SCO_WB] = "SND_DEVICE_OUT_BT_SCO_WB",
            [AcdbDevices.SND_DEVICE_OUT_BT_A2DP] = "SND_DEVICE_OUT_BT_A2DP",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_BT_A2DP] = "SND_DEVICE_OUT_SPEAKER_AND_BT_A2DP",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_BT_SCO] = "SND_DEVICE_OUT_SPEAKER_AND_BT_SCO",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_BT_SCO_WB] = "SND_DEVICE_OUT_SPEAKER_AND_BT_SCO_WB",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_FULL_HEADPHONES] = "SND_DEVICE_OUT_VOICE_TTY_FULL_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_VCO_HEADPHONES] = "SND_DEVICE_OUT_VOICE_TTY_VCO_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_HCO_HANDSET] = "SND_DEVICE_OUT_VOICE_TTY_HCO_HANDSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_FULL_USB] = "SND_DEVICE_OUT_VOICE_TTY_FULL_USB",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_VCO_USB] = "SND_DEVICE_OUT_VOICE_TTY_VCO_USB",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TX] = "SND_DEVICE_OUT_VOICE_TX",
            [AcdbDevices.SND_DEVICE_OUT_AFE_PROXY] = "SND_DEVICE_OUT_AFE_PROXY",
            [AcdbDevices.SND_DEVICE_OUT_USB_HEADSET] = "SND_DEVICE_OUT_USB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_USB_HEADPHONES] = "SND_DEVICE_OUT_USB_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_USB_HEADSET] = "SND_DEVICE_OUT_SPEAKER_AND_USB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_USB_HEADPHONES] = "SND_DEVICE_OUT_VOICE_USB_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_USB_HEADSET] = "SND_DEVICE_OUT_VOICE_USB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_TRANSMISSION_FM] = "SND_DEVICE_OUT_TRANSMISSION_FM",
            [AcdbDevices.SND_DEVICE_OUT_ANC_HEADSET] = "SND_DEVICE_OUT_ANC_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_ANC_FB_HEADSET] = "SND_DEVICE_OUT_ANC_FB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_ANC_HEADSET] = "SND_DEVICE_OUT_VOICE_ANC_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_ANC_FB_HEADSET] = "SND_DEVICE_OUT_VOICE_ANC_FB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_ANC_HEADSET] = "SND_DEVICE_OUT_SPEAKER_AND_ANC_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_ANC_FB_HEADSET] = "SND_DEVICE_OUT_SPEAKER_AND_ANC_FB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_ANC_HANDSET] = "SND_DEVICE_OUT_ANC_HANDSET",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_PROTECTED] = "SND_DEVICE_OUT_SPEAKER_PROTECTED",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_PROTECTED] = "SND_DEVICE_OUT_VOICE_SPEAKER_PROTECTED",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_2_PROTECTED] = "SND_DEVICE_OUT_VOICE_SPEAKER_2_PROTECTED",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_STEREO_PROTECTED] = "SND_DEVICE_OUT_VOICE_SPEAKER_STEREO_PROTECTED",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_PROTECTED_VBAT] = "SND_DEVICE_OUT_SPEAKER_PROTECTED_VBAT",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_PROTECTED_VBAT] = "SND_DEVICE_OUT_VOICE_SPEAKER_PROTECTED_VBAT",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_SPEAKER_2_PROTECTED_VBAT] = "SND_DEVICE_OUT_VOICE_SPEAKER_2_PROTECTED_VBAT",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_PROTECTED_RAS] = "SND_DEVICE_OUT_SPEAKER_PROTECTED_RAS",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_PROTECTED_VBAT_RAS] = "SND_DEVICE_OUT_SPEAKER_PROTECTED_VBAT_RAS",
            [AcdbDevices.SND_DEVICE_OUT_HEADPHONES_VOIP] = "SND_DEVICE_OUT_HEADPHONES_VOIP",
            [AcdbDevices.SND_DEVICE_OUT_HI_HEADPHONES_VOIP] = "SND_DEVICE_OUT_HI_HEADPHONES_VOIP",
            [AcdbDevices.SND_DEVICE_OUT_HI_HEADPHONES] = "SND_DEVICE_OUT_HI_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_HI_HEADPHONES_44_1] = "SND_DEVICE_OUT_HI_HEADPHONES_44_1",
            [AcdbDevices.SND_DEVICE_OUT_SPEAKER_AND_HI_HEADPHONES] = "SND_DEVICE_OUT_SPEAKER_AND_HI_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_RINGTONE_SPEAKER] = "SND_DEVICE_OUT_RINGTONE_SPEAKER",
            [AcdbDevices.SND_DEVICE_OUT_RINGTONE_SPEAKER_AND_HEADPHONES] = "SND_DEVICE_OUT_RINGTONE_SPEAKER_AND_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_RINGTONE_SPEAKER_AND_USB_HEADSET] = "SND_DEVICE_OUT_RINGTONE_SPEAKER_AND_USB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_RINGTONE_SPEAKER_AND_HI_HEADPHONES] = "SND_DEVICE_OUT_RINGTONE_SPEAKER_AND_HI_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_FQC_VOICE_HANDSET] = "SND_DEVICE_OUT_FQC_VOICE_HANDSET",
            [AcdbDevices.SND_DEVICE_OUT_HAC_VOICE_HANDSET] = "SND_DEVICE_OUT_HAC_VOICE_HANDSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_HCO_USB_HEADSET] = "SND_DEVICE_OUT_VOICE_TTY_HCO_USB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_VCO_USB_HEADPHONES] = "SND_DEVICE_OUT_VOICE_TTY_VCO_USB_HEADPHONES",
            [AcdbDevices.SND_DEVICE_OUT_VOICE_TTY_FULL_USB_HEADSET] = "SND_DEVICE_OUT_VOICE_TTY_FULL_USB_HEADSET",
            [AcdbDevices.SND_DEVICE_OUT_VOIP_SPEAKER] = "SND_DEVICE_OUT_VOIP_SPEAKER",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_MIC] = "SND_DEVICE_IN_HANDSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_MIC_EXTERNAL] = "SND_DEVICE_IN_HANDSET_MIC_EXTERNAL",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_MIC_AEC] = "SND_DEVICE_IN_HANDSET_MIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_MIC_NS] = "SND_DEVICE_IN_HANDSET_MIC_NS",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_MIC_AEC_NS] = "SND_DEVICE_IN_HANDSET_MIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_DMIC] = "SND_DEVICE_IN_HANDSET_DMIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_DMIC_AEC] = "SND_DEVICE_IN_HANDSET_DMIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_DMIC_NS] = "SND_DEVICE_IN_HANDSET_DMIC_NS",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_DMIC_AEC_NS] = "SND_DEVICE_IN_HANDSET_DMIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_MIC] = "SND_DEVICE_IN_SPEAKER_MIC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_MIC_AEC] = "SND_DEVICE_IN_SPEAKER_MIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_MIC_NS] = "SND_DEVICE_IN_SPEAKER_MIC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_MIC_AEC_NS] = "SND_DEVICE_IN_SPEAKER_MIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC] = "SND_DEVICE_IN_SPEAKER_DMIC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_AEC] = "SND_DEVICE_IN_SPEAKER_DMIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_NS] = "SND_DEVICE_IN_SPEAKER_DMIC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_AEC_NS] = "SND_DEVICE_IN_SPEAKER_DMIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_HEADSET_MIC] = "SND_DEVICE_IN_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_HEADSET_MIC_FLUENCE] = "SND_DEVICE_IN_HEADSET_MIC_FLUENCE",
            [AcdbDevices.SND_DEVICE_IN_VOICE_SPEAKER_MIC] = "SND_DEVICE_IN_VOICE_SPEAKER_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_HEADSET_MIC] = "SND_DEVICE_IN_VOICE_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_HDMI_MIC] = "SND_DEVICE_IN_HDMI_MIC",
            [AcdbDevices.SND_DEVICE_IN_BT_SCO_MIC] = "SND_DEVICE_IN_BT_SCO_MIC",
            [AcdbDevices.SND_DEVICE_IN_BT_SCO_MIC_NREC] = "SND_DEVICE_IN_BT_SCO_MIC_NREC",
            [AcdbDevices.SND_DEVICE_IN_BT_SCO_MIC_WB] = "SND_DEVICE_IN_BT_SCO_MIC_WB",
            [AcdbDevices.SND_DEVICE_IN_BT_SCO_MIC_WB_NREC] = "SND_DEVICE_IN_BT_SCO_MIC_WB_NREC",
            [AcdbDevices.SND_DEVICE_IN_CAMCORDER_MIC] = "SND_DEVICE_IN_CAMCORDER_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_DMIC] = "SND_DEVICE_IN_VOICE_DMIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_SPEAKER_DMIC] = "SND_DEVICE_IN_VOICE_SPEAKER_DMIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_SPEAKER_TMIC] = "SND_DEVICE_IN_VOICE_SPEAKER_TMIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_SPEAKER_QMIC] = "SND_DEVICE_IN_VOICE_SPEAKER_QMIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_TTY_FULL_HEADSET_MIC] = "SND_DEVICE_IN_VOICE_TTY_FULL_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_TTY_VCO_HANDSET_MIC] = "SND_DEVICE_IN_VOICE_TTY_VCO_HANDSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_TTY_HCO_HEADSET_MIC] = "SND_DEVICE_IN_VOICE_TTY_HCO_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_TTY_FULL_USB_MIC] = "SND_DEVICE_IN_VOICE_TTY_FULL_USB_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_TTY_HCO_USB_MIC] = "SND_DEVICE_IN_VOICE_TTY_HCO_USB_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_REC_MIC] = "SND_DEVICE_IN_VOICE_REC_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_REC_MIC_NS] = "SND_DEVICE_IN_VOICE_REC_MIC_NS",
            [AcdbDevices.SND_DEVICE_IN_VOICE_REC_DMIC_STEREO] = "SND_DEVICE_IN_VOICE_REC_DMIC_STEREO",
            [AcdbDevices.SND_DEVICE_IN_VOICE_REC_DMIC_FLUENCE] = "SND_DEVICE_IN_VOICE_REC_DMIC_FLUENCE",
            [AcdbDevices.SND_DEVICE_IN_VOICE_RX] = "SND_DEVICE_IN_VOICE_RX",
            [AcdbDevices.SND_DEVICE_IN_USB_HEADSET_MIC] = "SND_DEVICE_IN_USB_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_USB_HEADSET_MIC_AEC] = "SND_DEVICE_IN_USB_HEADSET_MIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_USB_HEADSET_MIC] = "SND_DEVICE_IN_VOICE_USB_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_USB_HEADSET_MIC] = "SND_DEVICE_IN_UNPROCESSED_USB_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_RECOG_USB_HEADSET_MIC] = "SND_DEVICE_IN_VOICE_RECOG_USB_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_USB_HEADSET_MULTI_CHANNEL_MIC] = "SND_DEVICE_IN_USB_HEADSET_MULTI_CHANNEL_MIC",
            [AcdbDevices.SND_DEVICE_IN_USB_HEADSET_MULTI_CHANNEL_MIC_AEC] = "SND_DEVICE_IN_USB_HEADSET_MULTI_CHANNEL_MIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_USB_HEADSET_MULTI_CHANNEL_MIC] = "SND_DEVICE_IN_UNPROCESSED_USB_HEADSET_MULTI_CHANNEL_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_RECOG_USB_HEADSET_MULTI_CHANNEL_MIC] = "SND_DEVICE_IN_VOICE_RECOG_USB_HEADSET_MULTI_CHANNEL_MIC",
            [AcdbDevices.SND_DEVICE_IN_CAPTURE_FM] = "SND_DEVICE_IN_CAPTURE_FM",
            [AcdbDevices.SND_DEVICE_IN_AANC_HANDSET_MIC] = "SND_DEVICE_IN_AANC_HANDSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_QUAD_MIC] = "SND_DEVICE_IN_QUAD_MIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_STEREO_DMIC] = "SND_DEVICE_IN_HANDSET_STEREO_DMIC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_STEREO_DMIC] = "SND_DEVICE_IN_SPEAKER_STEREO_DMIC",
            [AcdbDevices.SND_DEVICE_IN_CAPTURE_VI_FEEDBACK] = "SND_DEVICE_IN_CAPTURE_VI_FEEDBACK",
            [AcdbDevices.SND_DEVICE_IN_CAPTURE_VI_FEEDBACK_MONO_1] = "SND_DEVICE_IN_CAPTURE_VI_FEEDBACK_MONO_1",
            [AcdbDevices.SND_DEVICE_IN_CAPTURE_VI_FEEDBACK_MONO_2] = "SND_DEVICE_IN_CAPTURE_VI_FEEDBACK_MONO_2",
            [AcdbDevices.SND_DEVICE_IN_VOICE_SPEAKER_DMIC_BROADSIDE] = "SND_DEVICE_IN_VOICE_SPEAKER_DMIC_BROADSIDE",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_BROADSIDE] = "SND_DEVICE_IN_SPEAKER_DMIC_BROADSIDE",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_AEC_BROADSIDE] = "SND_DEVICE_IN_SPEAKER_DMIC_AEC_BROADSIDE",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_NS_BROADSIDE] = "SND_DEVICE_IN_SPEAKER_DMIC_NS_BROADSIDE",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_DMIC_AEC_NS_BROADSIDE] = "SND_DEVICE_IN_SPEAKER_DMIC_AEC_NS_BROADSIDE",
            [AcdbDevices.SND_DEVICE_IN_VOICE_FLUENCE_DMIC_AANC] = "SND_DEVICE_IN_VOICE_FLUENCE_DMIC_AANC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_QMIC] = "SND_DEVICE_IN_HANDSET_QMIC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_QMIC_AEC] = "SND_DEVICE_IN_SPEAKER_QMIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_QMIC_NS] = "SND_DEVICE_IN_SPEAKER_QMIC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_QMIC_AEC_NS] = "SND_DEVICE_IN_SPEAKER_QMIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_VOICE_REC_QMIC_FLUENCE] = "SND_DEVICE_IN_VOICE_REC_QMIC_FLUENCE",
            [AcdbDevices.SND_DEVICE_IN_THREE_MIC] = "SND_DEVICE_IN_THREE_MIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_TMIC_FLUENCE_PRO] = "SND_DEVICE_IN_HANDSET_TMIC_FLUENCE_PRO",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_TMIC] = "SND_DEVICE_IN_HANDSET_TMIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_TMIC_AEC] = "SND_DEVICE_IN_HANDSET_TMIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_TMIC_NS] = "SND_DEVICE_IN_HANDSET_TMIC_NS",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_TMIC_AEC_NS] = "SND_DEVICE_IN_HANDSET_TMIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_TMIC_AEC] = "SND_DEVICE_IN_SPEAKER_TMIC_AEC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_TMIC_NS] = "SND_DEVICE_IN_SPEAKER_TMIC_NS",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_TMIC_AEC_NS] = "SND_DEVICE_IN_SPEAKER_TMIC_AEC_NS",
            [AcdbDevices.SND_DEVICE_IN_VOICE_REC_TMIC] = "SND_DEVICE_IN_VOICE_REC_TMIC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_MIC] = "SND_DEVICE_IN_UNPROCESSED_MIC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_STEREO_MIC] = "SND_DEVICE_IN_UNPROCESSED_STEREO_MIC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_THREE_MIC] = "SND_DEVICE_IN_UNPROCESSED_THREE_MIC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_QUAD_MIC] = "SND_DEVICE_IN_UNPROCESSED_QUAD_MIC",
            [AcdbDevices.SND_DEVICE_IN_UNPROCESSED_HEADSET_MIC] = "SND_DEVICE_IN_UNPROCESSED_HEADSET_MIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_GENERIC_QMIC] = "SND_DEVICE_IN_HANDSET_GENERIC_QMIC",
            [AcdbDevices.SND_DEVICE_IN_HANDSET_VOIP_DMIC] = "SND_DEVICE_IN_HANDSET_VOIP_DMIC",
            [AcdbDevices.SND_DEVICE_IN_HEADSET_VOIP_MIC] = "SND_DEVICE_IN_HEADSET_VOIP_MIC",
            [AcdbDevices.SND_DEVICE_IN_SPEAKER_VOIP_MIC] = "SND_DEVICE_IN_SPEAKER_VOIP_MIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_HEADSET_DMIC] = "SND_DEVICE_IN_VOICE_HEADSET_DMIC",
            [AcdbDevices.SND_DEVICE_IN_VOICE_HANDSET_MIC_REC] = "SND_DEVICE_IN_VOICE_HANDSET_MIC_REC",
        };
    }
}