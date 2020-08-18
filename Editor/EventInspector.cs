﻿using UnityEditor;
using UnityEngine;

namespace lisandroct.EventSystem
{
    [CustomEditor(typeof(Event))]
    public class EventInspector : Editor
    {
        private Event Target => target as Event;
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;
            
            EditorGUILayout.Space();
            
            if (GUILayout.Button("Raise"))
            {
                Target.Raise();
            }
        }
    }
    
    public class EventInspector<T, S> : Editor where S : TestObject<T>
    {
        private Event<object> Target => target as Event<object>;

        private S TestObject { get; set; }
        private SerializedProperty Argument0Property { get; set; }
        
        private void OnEnable()
        {
            TestObject = (S) CreateInstance(typeof(S));
            
            var serializedObject = new SerializedObject(TestObject);
            
            Argument0Property = serializedObject.FindProperty("argument0");
        }
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            
            if (!Application.isPlaying) return;
            
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(Argument0Property);

            EditorGUILayout.Space();
            
            if (GUILayout.Button("Raise"))
            {
                Target.Raise(TestObject.Argument0);
            }
        }
    }
    
    public abstract class EventInspector<T, U, S> : Editor where S : TestObject<T, U>
    {
        private Event<T, U> Target => target as Event<T, U>;

        private S TestObject { get; set; }
        private SerializedProperty Argument0Property { get; set; }
        private SerializedProperty Argument1Property { get; set; }
        
        private void OnEnable()
        {
            TestObject = (S) CreateInstance(typeof(S));
            
            var serializedObject = new SerializedObject(TestObject);
            
            Argument0Property = serializedObject.FindProperty("argument0");
            Argument1Property = serializedObject.FindProperty("argument1");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;
            
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(Argument0Property);
            EditorGUILayout.PropertyField(Argument1Property);
            
            EditorGUILayout.Space();
            
            if (GUILayout.Button("Raise"))
            {
                Target.Raise(TestObject.Argument0, TestObject.Argument1);
            }
        }
    }
    
    public abstract class EventInspector<T, U, V, S> : Editor where S : TestObject<T, U, V>
    {
        private Event<T, U, V> Target => target as Event<T, U, V>;

        private S TestObject { get; set; }
        private SerializedProperty Argument0Property { get; set; }
        private SerializedProperty Argument1Property { get; set; }
        private SerializedProperty Argument2Property { get; set; }
        
        private void OnEnable()
        {
            TestObject = (S) CreateInstance(typeof(S));
            
            var serializedObject = new SerializedObject(TestObject);
            
            Argument0Property = serializedObject.FindProperty("argument0");
            Argument1Property = serializedObject.FindProperty("argument1");
            Argument2Property = serializedObject.FindProperty("argument2");
        }
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;
            
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(Argument0Property);
            EditorGUILayout.PropertyField(Argument1Property);
            EditorGUILayout.PropertyField(Argument2Property);
            
            EditorGUILayout.Space();
            
            if (GUILayout.Button("Raise"))
            {
                Target.Raise(TestObject.Argument0, TestObject.Argument1, TestObject.Argument2);
            }
        }
    }
    
    public abstract class EventInspector<T, U, V, W, S> : Editor where S : TestObject<T, U, V, W>
    {
        private Event<T, U, V, W> Target => target as Event<T, U, V, W>;

        private S TestObject { get; set; }
        private SerializedProperty Argument0Property { get; set; }
        private SerializedProperty Argument1Property { get; set; }
        private SerializedProperty Argument2Property { get; set; }
        private SerializedProperty Argument3Property { get; set; }
        
        private void OnEnable()
        {
            TestObject = (S) CreateInstance(typeof(S));
            
            var serializedObject = new SerializedObject(TestObject);
            
            Argument0Property = serializedObject.FindProperty("argument0");
            Argument1Property = serializedObject.FindProperty("argument1");
            Argument2Property = serializedObject.FindProperty("argument2");
            Argument3Property = serializedObject.FindProperty("argument3");
        }
        
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (!Application.isPlaying) return;
            
            EditorGUILayout.Space();

            EditorGUILayout.PropertyField(Argument0Property);
            EditorGUILayout.PropertyField(Argument1Property);
            EditorGUILayout.PropertyField(Argument2Property);
            EditorGUILayout.PropertyField(Argument3Property);
            
            EditorGUILayout.Space();
            
            if (GUILayout.Button("Raise"))
            {
                Target.Raise(TestObject.Argument0, TestObject.Argument1, TestObject.Argument2, TestObject.Argument3);
            }
        }
    }
}