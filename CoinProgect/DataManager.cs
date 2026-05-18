using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

/// <summary>
/// Менеджер даних, який керує колекціями об'єктів у пам'яті (BindingList) 
/// та відповідає за їх збереження і завантаження з диска.
/// </summary>
public class SaveDataModel {
    public List<Coin> SavedCoins { get; set; } = new List<Coin>();
    public List<Collector> SavedCollectors { get; set; } = new List<Collector>();
}

public class DataManager {

    public BindingList<Coin> Coins { get; set; } = new BindingList<Coin>();
    public BindingList<Collector> Collectors { get; set; } = new BindingList<Collector>();

    private readonly string filePath = "MyCollectionData.json";


    public void AddCoin(Coin coin) => Coins.Add(coin);
    public void DeleteCoin(Coin coin) => Coins.Remove(coin);

    public void AddCollector(Collector collector) => Collectors.Add(collector);
    public void DeleteCollector(Collector collector) => Collectors.Remove(collector);


    public void SaveToFile() {
        var dataToSave = new SaveDataModel {
            SavedCoins = new List<Coin>(Coins),
            SavedCollectors = new List<Collector>(Collectors)
        };

        var options = new JsonSerializerOptions {
            WriteIndented = true,
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
        };

        string jsonString = JsonSerializer.Serialize(dataToSave, options);
        File.WriteAllText(filePath, jsonString);
    }
    public void LoadFromFile() {
        if (!File.Exists(filePath)) return;

        try {
            string jsonString = File.ReadAllText(filePath);
            var loadedData = JsonSerializer.Deserialize<SaveDataModel>(jsonString);

            if (loadedData != null) {
                Coins.Clear();
                foreach (var coin in loadedData.SavedCoins) {
                    Coins.Add(coin);
                }
                Collectors.Clear();
                foreach (var collector in loadedData.SavedCollectors) {
                    Collectors.Add(collector);
                }
            }
        } catch (Exception ex) {
            throw new Exception("Помилка при завантаженні даних: " + ex.Message);
        }
    }
}