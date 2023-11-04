using System.ComponentModel.DataAnnotations;
/// <summary>
/// Добавляет поддержку нового устройства.
/// </summary>
public class AddDeviceRequest
{
    [Required] // Указываем все параметры как обязательные
    public string Name { get; set; }
    [Required]
    public string Manufacturer { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public string SerialNumber { get; set; }

    // Указываем допустимый диапазон значений и даже текст ошибки в случае нарушения
 
    public int CurrentVolts { get; set; }
    [Required]
    public bool GasUsage { get; set; }
    [Required]
    public string Location { get; set; }
}