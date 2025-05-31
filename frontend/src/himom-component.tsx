import React from "react";

interface Props {
   name: string;
}

const HimomComponent = (props: Props) => {
   return (
      <div>
         Hello {props.name}
      </div>
   );
}

export default HimomComponent;