import { TestBed } from '@angular/core/testing';

import { DbOperations } from './db-operations';

describe('DbOperations', () => {
  let service: DbOperations;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DbOperations);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
