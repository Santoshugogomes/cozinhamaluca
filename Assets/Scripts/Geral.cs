using UnityEngine;
using UnityEngine.UI;

public class Geral : MonoBehaviour
{
    internal int placarJogadorNum, recordeNum;
    public Text placarJogadorTexto, recordeTexto;
    public AudioSource somPontoGanho;

    public GameObject telaBoasVindas, telaGameOver;
    public ControladorVoador objetoVoador;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarJogadorNum = 0;
       

        AtualizarTextoPlacar();

        Time.timeScale = 0;
    }

    public void MarcarPonto()
    {
        placarJogadorNum += 1;

        if (recordeNum < placarJogadorNum) 
            recordeNum += 1;

        AtualizarTextoPlacar();

        somPontoGanho.Play();
    }

    public void AtualizarTextoPlacar()
    {
        placarJogadorTexto.text = "Itens coletados: " + placarJogadorNum;
        recordeTexto.text = "Recorde atual: " + recordeNum;


    }

    public void ComecarJogo()
    {
        Time.timeScale = 1;
        telaBoasVindas.SetActive(false);
        telaGameOver.SetActive(false);

        objetoVoador.deslocamentoAbs = objetoVoador.deslocamentoObjeto;
        objetoVoador.posicaoObj.x = objetoVoador.posInicialX;

        placarJogadorNum = 0;
        AtualizarTextoPlacar();

    }

}
