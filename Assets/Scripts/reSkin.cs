using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;//da acesso a mudar o dicionario das animações

public class reSkin : MonoBehaviour
{
    private SpriteRenderer sRender;

    public Sprite[] sprites; //vetor que irá armazenar todos os sprites do personagem escolhido

    public string spriteSheetName;//nome da imagem que contem os sprites do personagem escolhido
    public string loadedSpriteSheetName;//nome do spriteSheet em uso caso o personagem tenha mudado

    private Dictionary<string, Sprite> spriteSheet; //dicionario que armazena as informações dos sprites


    void Start()
    {
        sRender = GetComponent<SpriteRenderer>();//inicia o rRender
        loadSpriteSheet();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (loadedSpriteSheetName != spriteSheetName)//caso haja mudança de personagem
 {
            loadSpriteSheet();
        }
        sRender.sprite = spriteSheet[sRender.sprite.name];//amarra as animações com o nome atual do Dicionariry
 }

    private void loadSpriteSheet()
    {
        sprites = Resources.LoadAll<Sprite>(spriteSheetName);//carrega os sprites do nome que passamos pela variável spriteSheetName
        spriteSheet = sprites.ToDictionary(x => x.name, x => x);//alimentando o Dicionary com os sprites carregados
        loadedSpriteSheetName = spriteSheetName;//informa qual o nome da imagem q esta atualmente em uso
}
}
