using UnityEngine;
using UnityEngine.UI;

public class UI_Lobby : MonoBehaviour
{
    public GameObject MaleCharacter;
    public GameObject FemaleCharacter;

    public InputField NicknameInputField;
    public InputField RoomNameInputField;
    public Button CreateRoomButton;
    
    private ECharacterType _characterType;
    
    
    


    // Todo: 버튼 연결
    public void OnClickMale() => OnClickCharacterButton(ECharacterType.Male);
    public void OnClickFemale() => OnClickCharacterButton(ECharacterType.Female);
    private void OnClickCharacterButton(ECharacterType characterType)
    {
        _characterType = characterType;
        
        MaleCharacter.SetActive(_characterType == ECharacterType.Male);
        FemaleCharacter.SetActive(_characterType == ECharacterType.Female);
    }
}
