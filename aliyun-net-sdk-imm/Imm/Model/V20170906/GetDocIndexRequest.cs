/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;
using System.Collections.Generic;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class GetDocIndexRequest : RpcAcsRequest<GetDocIndexResponse>
    {
        public GetDocIndexRequest()
            : base("imm", "2017-09-06", "GetDocIndex", "imm", "openAPI")
        {
        }

		private string _set;

		private string action;

		private string project;

		private string uniqueId;

		private string accessKeyId;

		public string _Set
		{
			get
			{
				return _set;
			}
			set	
			{
				_set = value;
				DictionaryUtil.Add(QueryParameters, "Set", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string UniqueId
		{
			get
			{
				return uniqueId;
			}
			set	
			{
				uniqueId = value;
				DictionaryUtil.Add(QueryParameters, "UniqueId", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetDocIndexResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetDocIndexResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}