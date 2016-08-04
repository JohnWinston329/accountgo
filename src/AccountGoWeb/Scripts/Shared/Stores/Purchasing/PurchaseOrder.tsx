﻿import PurchaseOrderLine from "./PurchaseOrderLine";

export default class PurchaseOrder {
    id: number;
    vendorId: number;
    orderDate: Date;
    paymentTermId: number;
    referenceNo: string;
    purchaseOrderLines: PurchaseOrderLine[] = [];
}