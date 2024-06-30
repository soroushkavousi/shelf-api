using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShelfApi.Domain.ErrorAggregate;

public enum ErrorCode : byte
{
    InternalServerError,
    InvalidPrice,
}