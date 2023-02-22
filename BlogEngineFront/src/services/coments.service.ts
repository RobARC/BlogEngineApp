import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { url_api } from 'src/app/app-constants';
import { IPost } from 'src/components/post/post.class';
import { CommentInterface } from '../components/coments/coment.class';

@Injectable({
  providedIn: 'root'
})
export class ComentsService {

  constructor(private http: HttpClient,
    private router: Router) { }


    async getComents(): Promise<Observable<CommentInterface[]>> {
      return this.http.get<CommentInterface[]>(`${url_api}/api/Coments`)
    }
}
