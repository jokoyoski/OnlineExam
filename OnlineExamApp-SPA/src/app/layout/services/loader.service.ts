import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable()
export class LoaderService {

public status: BehaviorSubject<number> = new BehaviorSubject<number>(0);
cast = this.status.asObservable();
display(value: number) {
this.status.next(value);
}
}
