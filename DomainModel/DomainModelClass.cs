namespace DomainModel
{
    public class DomainModelClass
    {
        public void CalculateWorkerSalary(List<DomainModelWorker> workerList)
        {
            CalculateManager calculateManager = new();
            foreach (var worker in workerList)
            {
                Console.WriteLine($"Çalışan direktör mü {worker.IsDirector} maaşı: {calculateManager.CalculateSummary(worker)}");
            }
        }
    }
}
