import { Component, OnInit } from '@angular/core';
import { BpressureService } from '../services/bpressure.service';
import { Bpressure } from '../models/bpressure';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  bpressure = {} as Bpressure;
  bpressures: Bpressure[];
  displayedColumns: string[] = [
    'bPressureId', 'systolic', 'dyastolic', 
    'meanAraterial', 'pressure', 'sleepStatus', 
    'dyastolicEndpoint', 'Editar', 'Excluir'
  ];

  constructor(private  bpressureService: BpressureService) {}

  ngOnInit() {
    this.getCars();
  }

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

}
