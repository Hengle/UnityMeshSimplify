﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UltimateGameTools
{
    namespace MeshSimplifier
    {

        /// <summary>
        /// A list of vertex indices. We use this in order to be able to serialize a list of lists.
        /// </summary>
        [Serializable]
        public class ListIndices
        {
            public ListIndices(int capacity)
            {
                m_listIndices = new List<int>(capacity);
            }

            public List<int> m_listIndices;
        }
    }
}
