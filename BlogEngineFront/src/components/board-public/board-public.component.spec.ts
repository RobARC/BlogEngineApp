import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardPublicComponent } from './board-public.component';

describe('BoardPublicComponent', () => {
  let component: BoardPublicComponent;
  let fixture: ComponentFixture<BoardPublicComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BoardPublicComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BoardPublicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
