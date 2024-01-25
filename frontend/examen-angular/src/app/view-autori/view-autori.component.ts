import { Component, OnInit } from '@angular/core';
import { AutorService } from '../autor.service';
import { Observable, Subscription, interval, take } from 'rxjs';
import { NgForOf } from '@angular/common';
import { RouterLink } from '@angular/router';
import { Autor } from '../autor';

@Component({
  selector: 'app-view-autori',
  standalone: true,
  imports: [
    RouterLink,
    NgForOf,
    ViewAutoriComponent
  ],
  templateUrl: './view-autori.component.html',
  styleUrl: './view-autori.component.css'
})
export class ViewAutoriComponent implements OnInit {
  constructor(private autorService: AutorService){}
  ngOnInit(): void {
    this.source$ = interval(200);
    this.sourceSubscription = this.source$.subscribe((x: any) => console.log(x));
    this.autorService.getAutori().pipe(take(1)).subscribe(
      (x: Autor[]) => {
        console.log(x);
      }
    )
  }
  public source$: Observable<Number>;
  public sourceSubscription: Subscription;
}
