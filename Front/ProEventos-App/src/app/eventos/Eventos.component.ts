import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { subscribeOn } from 'rxjs';

@Component({
  selector: 'app-Eventos',
  templateUrl: './Eventos.component.html',
  styleUrls: ['./Eventos.component.css']
})
export class EventosComponent implements OnInit {

  isCollapsed = true;
  buttonText = "Exibir";

  public eventosFiltrados: any = {};
  public eventos: any = [];
  widthImg: number = 50;
  marginImg: number = 2;
  private _filtroLista: string = '';

  onCollapsed()
  {
    this.isCollapsed = !this.isCollapsed;
    this.buttonText = this.isCollapsed ? "Exibir" : "Ocultar";
  }

  public get filtroLista() : string {
      return this._filtroLista
  }

  public set filtroLista(value: string) {
    this._filtroLista = value;
    this.eventosFiltrados = this._filtroLista ? this.filtrarEventos(this._filtroLista) : this.eventos;
  }

  filtrarEventos(filtrarPor: string) : any {
    filtrarPor = filtrarPor.toLocaleLowerCase();
    return this.eventos.filter(
      (evento: any) => evento.tema.toLocaleLowerCase().indexOf(filtrarPor) !== -1 ||
      evento.local.toLocaleLowerCase().indexOf(filtrarPor)
    )
  }

  constructor(private http: HttpClient) { }

  ngOnInit()
  {
    this.getEventos();
  }

 public getEventos(): void
 {
   this.http.get('https://localhost:5001/api/eventos').subscribe(
  response => {
    this.eventos = response,
    this.eventosFiltrados = this.eventos;
  },
    error => console.log(error)
  );
 }

}

//
//public getEventos(): void
// {
//  this.http.get('https://localhost:5001/api/eventos').subscribe(
// response => this.eventos = response,
// error => console.log(error)
// );
// }
//
//
//
