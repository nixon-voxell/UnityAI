﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bigtree.Algorithm.CRFLite
{
    public class Node
    {
        public int fid;
        public short x;
        public short y;
        public double alpha;
        public double beta;
        public double cost;
        public double bestCost;
        public Node prev;

        public List<Path> lpathList;
        public List<Path> rpathList;
    }
}
