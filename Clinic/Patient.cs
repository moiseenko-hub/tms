namespace Clinic;

public class Patient(string name, TreatmentPlan plan = null)
{
    public string Name { get; private set; } = name;
    public TreatmentPlan TreatmentPlan { get; private set; } = plan;

    public void SetTratementPlan(TreatmentPlan treatmentPlan)
    {
        this.TreatmentPlan = treatmentPlan;
    }
}