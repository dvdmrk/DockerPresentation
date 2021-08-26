import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'DockerRockstarSpa';
  public containerCounters: ContainerCounter[];
  
  constructor(http: HttpClient) {
    http.get<ContainerCounter[]>('http://localhost:5000/api/Test').subscribe(result => {
      this.containerCounters = result;
    }, error => console.error(error));
  }
}
interface ContainerCounter {
  count: number;
  containerId: string;
}