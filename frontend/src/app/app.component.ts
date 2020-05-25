import { Component, OnInit } from '@angular/core';
import { BpressureService } from './services/bpressure.service';
import { Bpressure } from './models/bpressure';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor() {}

  ngOnInit() {
    
  }
  //title = 'Blood Pressure';
/*
  bpressure = {} as Bpressure;
  bpressures: Bpressure[];

  constructor(private  bpressureService: BpressureService) {}

  ngOnInit() {
    this.getCars();
  }
/*
  saveCar(from: NgForm) {
    if (this.bpressure.id !== undefined) {
      this.bpressureService.updateCar(this.bpressure).subscribe(() => {
        this.cleanForm(form);
      });
    } else {
      this.bpressureService.saveCar(this.bpressure).subscribe(() => {
        this.cleanForm(form);
      });
    }
  }

  // Chama o serviço para obtém todos os carros
  getCars() {
    this.bpressureService.getCars().subscribe((bpressures: Bpressure[]) => {
      this.bpressures = bpressures;
    });
  }

  // deleta um carro
  deleteCar(bpressure: Bpressure) {
    this.bpressureService.deleteCar(bpressure).subscribe(() => {
      this.getCars();
    });
  }

  // copia o carro para ser editado.
  editCar(bpressure: Bpressure) {
    this.bpressure = { ...bpressure };
  }

  // limpa o formulario
  cleanForm(form: NgForm) {
    this.getCars();
    form.resetForm();
    bpressure = {} as Bpressure;
  }
*/
}
