﻿namespace Tensorflow.Keras.Metrics;

public interface IMetricsApi
{
    Tensor binary_accuracy(Tensor y_true, Tensor y_pred);

    Tensor categorical_accuracy(Tensor y_true, Tensor y_pred);
    Tensor categorical_crossentropy(Tensor y_true, Tensor y_pred, 
        bool from_logits = false, 
        float label_smoothing = 0f,
        Axis? axis = null);

    Tensor mean_absolute_error(Tensor y_true, Tensor y_pred);

    Tensor mean_absolute_percentage_error(Tensor y_true, Tensor y_pred);

    /// <summary>
    /// Calculates how often predictions matches integer labels.
    /// </summary>
    /// <param name="y_true">Integer ground truth values.</param>
    /// <param name="y_pred">The prediction values.</param>
    /// <returns>Sparse categorical accuracy values.</returns>
    Tensor sparse_categorical_accuracy(Tensor y_true, Tensor y_pred);

    /// <summary>
    /// Computes how often targets are in the top `K` predictions.
    /// </summary>
    /// <param name="y_true"></param>
    /// <param name="y_pred"></param>
    /// <param name="k"></param>
    /// <returns></returns>
    Tensor top_k_categorical_accuracy(Tensor y_true, Tensor y_pred, int k = 5);

    /// <summary>
    /// Calculates how often predictions equal labels.
    /// </summary>
    /// <returns></returns>
    IMetricFunc Accuracy(string name = "accuracy",
        TF_DataType dtype = TF_DataType.TF_FLOAT);

    /// <summary>
    /// Calculates how often predictions match binary labels.
    /// </summary>
    /// <returns></returns>
    IMetricFunc BinaryAccuracy(string name = "binary_accuracy",
        TF_DataType dtype = TF_DataType.TF_FLOAT,
        float threshold = 05f);

    /// <summary>
    /// Calculates how often predictions match one-hot labels.
    /// </summary>
    /// <returns></returns>
    IMetricFunc CategoricalCrossentropy(string name = "categorical_crossentropy", 
        TF_DataType dtype = TF_DataType.TF_FLOAT,
        bool from_logits = false,
        float label_smoothing = 0f,
        Axis? axis = null);

    /// <summary>
    /// Computes the crossentropy metric between the labels and predictions.
    /// </summary>
    /// <returns></returns>
    IMetricFunc CategoricalAccuracy(string name = "categorical_accuracy", 
        TF_DataType dtype = TF_DataType.TF_FLOAT);

    /// <summary>
    /// Computes the cosine similarity between the labels and predictions.
    /// </summary>
    /// <returns></returns>
    IMetricFunc CosineSimilarity(string name = "cosine_similarity",
        TF_DataType dtype = TF_DataType.TF_FLOAT,
        Axis? axis = null);

    /// <summary>
    /// Computes how often targets are in the top K predictions.
    /// </summary>
    /// <param name="k"></param>
    /// <returns></returns>
    IMetricFunc TopKCategoricalAccuracy(int k = 5, 
        string name = "top_k_categorical_accuracy", 
        TF_DataType dtype = TF_DataType.TF_FLOAT);

    /// <summary>
    /// Computes the precision of the predictions with respect to the labels.
    /// </summary>
    /// <param name="thresholds"></param>
    /// <param name="top_k"></param>
    /// <param name="class_id"></param>
    /// <param name="name"></param>
    /// <param name="dtype"></param>
    /// <returns></returns>
    IMetricFunc Precision(float thresholds = 0.5f, 
        int top_k = 0, 
        int class_id = 0, 
        string name = "recall", 
        TF_DataType dtype = TF_DataType.TF_FLOAT);

    /// <summary>
    /// Computes the recall of the predictions with respect to the labels.
    /// </summary>
    /// <param name="thresholds"></param>
    /// <param name="top_k"></param>
    /// <param name="class_id"></param>
    /// <param name="name"></param>
    /// <param name="dtype"></param>
    /// <returns></returns>
    IMetricFunc Recall(float thresholds = 0.5f, 
        int top_k = 0, 
        int class_id = 0, 
        string name = "recall", 
        TF_DataType dtype = TF_DataType.TF_FLOAT);
}
