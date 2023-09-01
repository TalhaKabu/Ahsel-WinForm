export interface Project {
  id: number;
  name: string;
  description?: string;
}

export interface Client {
  id: number;
  name: string;
  projectRef: number;
}

export interface Payment {
  id: number;
  clientRef: number;
  projectRef: number;
  quantity: number;
  price: number;
  date: Date;
  description?: string;
}

export interface PaymentDto extends Payment {
  clientName: string;
}

export interface ClientGroupDto {
  id: number;
  name: string;
  projectRef: number;
  total: number;
  remainPayment?: number;
  paymentList: Payment[];
}
