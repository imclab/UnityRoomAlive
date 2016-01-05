﻿using UnityEngine;

namespace Ensemble {
    public struct ProjectorData {
        public Matrix4x4 cameraMatrix;
        public int displayIndex;
        public int width;
        public int height;
        public string hostNameOrAddress;
        public Matrix4x4 lensDistortion;
        public bool lockIntrinsics;
        public string name;
        public Matrix4x4 pose;
    }
}
