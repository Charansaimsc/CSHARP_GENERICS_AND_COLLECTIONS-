/*Hospital Triage System
Simulate a hospital triage system using a PriorityQueue where patients with
higher severity are treated first.

Example:
Patients: [ ("John", 3), ("Alice", 5), ("Bob", 2) ]
Order: Alice, John, Bob*/
using System;
using System.Collections.Generic;
class Hospital
{
    public static PriorityQueue<string,int> TreatmentOrder(){
    PriorityQueue<string,int> pq = new PriorityQueue<string,int>();
    pq.Enqueue("sai",-3);
    pq.Enqueue("charan",-9);
    pq.Enqueue("muchakarla",-1);

    return pq;
    }
}
