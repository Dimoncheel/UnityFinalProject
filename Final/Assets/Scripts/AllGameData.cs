using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllGameData : MonoBehaviour
{
    private static bool _isMeatPeaked=false;
    private static bool _isSoucePeaked=false;
    private static bool _isLavashPeaked = false;
    private static bool _isShaurmaReady = false;
    private static bool _isDie = false;
    private static float _musicVolume=0.5f;
    private static bool _enabledMusic = false;
    private static bool _enabledTaskPanel=false;

    private Vector3 _characterPosition;


    public static bool IsMeatPeaked
    {
        get => _isMeatPeaked;
        set => _isMeatPeaked = value;
    }

    public static bool IsSoucePeaked
    {
        get => _isSoucePeaked;
        set => _isSoucePeaked = value;
    }
    public static bool IsLavashPeacked
    {
        get => _isLavashPeaked; 
        set => _isLavashPeaked = value;
    }

    public static bool IsShaurmaReady
    {
        get => _isShaurmaReady;
        set => _isShaurmaReady = value;
    }
   public static bool IsDie
    {
        get => _isDie;
        set => _isDie = value;
    }

    public static float MusicVolume
    {
        get => _musicVolume;
        set=> _musicVolume = value;
    }
    public static bool EnabledMusic
    {
        get => _enabledMusic;
        set => _enabledMusic = value;
    }
    public  static bool EnabledTaskPanel
    {
        get => _enabledTaskPanel; 
        set => _enabledTaskPanel = value;
    }
}
