/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System.Collections.Generic;

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
     /// <summary>
     ///   DescribeClusterSnapshotsResult Unmarshaller
     /// </summary>
    internal class DescribeClusterSnapshotsResultUnmarshaller : IUnmarshaller<DescribeClusterSnapshotsResult, XmlUnmarshallerContext>, IUnmarshaller<DescribeClusterSnapshotsResult, JsonUnmarshallerContext> 
    {
        public DescribeClusterSnapshotsResult Unmarshall(XmlUnmarshallerContext context) 
        {
            DescribeClusterSnapshotsResult describeClusterSnapshotsResult = new DescribeClusterSnapshotsResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                { 
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        describeClusterSnapshotsResult.Marker = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    } 
                    if (context.TestExpression("Snapshots/Snapshot", targetDepth))
                    {
                        describeClusterSnapshotsResult.Snapshots.Add(SnapshotUnmarshaller.GetInstance().Unmarshall(context));
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return describeClusterSnapshotsResult;
                }
            }
                        


            return describeClusterSnapshotsResult;
        }

        public DescribeClusterSnapshotsResult Unmarshall(JsonUnmarshallerContext context) 
        {
            return null;
        }

        private static DescribeClusterSnapshotsResultUnmarshaller instance;

        public static DescribeClusterSnapshotsResultUnmarshaller GetInstance() 
        {
            if (instance == null) 
               instance = new DescribeClusterSnapshotsResultUnmarshaller();

            return instance;
        }
    }
}
    
