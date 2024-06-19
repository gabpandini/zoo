namespace zoo.Interfaces
{  
  public interface INadar
  {
    double LimiteProfundidade { get; set; }
	  void Subir(double metros);
	  void Descer(double metros);
  }
}
