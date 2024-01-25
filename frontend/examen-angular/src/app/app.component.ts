import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { AutorService } from './autor.service';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  constructor(private autorService: AutorService){}
  ngOnInit(): void {
    this.autorService.getAutori().subscribe((x: any) => console.log(x));
  }

  title = 'autori'
  public titlu: string = 'autori';
}
